using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using API.Helpers.JWT;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace API.Services;
/* public class ClienteService : IClienteService
{
    private readonly JWT _jwt;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordHasher<Cliente> _passwordHasher;
    public ClienteService(IUnitOfWork unitOfWork, IOptions<JWT> jwt, IPasswordHasher<Cliente> passwordHasher)
    {
        _jwt = jwt.Value;
        _unitOfWork = unitOfWork;
        _passwordHasher = passwordHasher;
    }
    public async Task<string> RegisterAsync(RegisterDto registerDto)
    {
        var Cliente = new Cliente
        {
            Email = registerDto.Email,
            Clientename = registerDto.Clientename,
            DateCreated = registerDto.DateCreated
        };

        Cliente.Password = _passwordHasher.HashPassword(Cliente, registerDto.Password);

        var existingCliente = _unitOfWork.Clientes
                                    .Find(u => u.Clientename.ToLower() == registerDto.Clientename.ToLower())
                                    .FirstOrDefault();

        if (existingCliente == null)
        {
            var rolDefault = _unitOfWork.Roles
                                    .Find(u => u.Nombre == Authorization.rol_default.ToString())
                                    .First();
            try
            {
                Cliente.Rols.Add(rolDefault);
                _unitOfWork.Clientes.Add(Cliente);
                await _unitOfWork.SaveAsync();

                return $"Cliente  {registerDto.Clientename} has been registered successfully";
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                return $"Error: {message}";
            }
        }
        else
        {
            return $"Cliente {registerDto.Clientename} already registered.";
        }
    }
    public async Task<DataClienteDto> GetTokenAsync(LoginDto model)
    {
        DataClienteDto dataClienteDto = new DataClienteDto();
        var Cliente = await _unitOfWork.Clientes
                    .GetByClientenameAsync(model.Clientename);

        if (Cliente == null)
        {
            dataClienteDto.IsAuthenticated = false;
            dataClienteDto.Message = $"Cliente does not exist with Clientename {model.Clientename}.";
            return dataClienteDto;
        }

        var result = _passwordHasher.VerifyHashedPassword(Cliente, Cliente.Password, model.Password);

        if (result == PasswordVerificationResult.Success)
        {
            dataClienteDto.Message = "EL CODIGO QR SE HA ENVIADO AL EMAIL!! <3";
            dataClienteDto.IsAuthenticated = true;
            JwtSecurityToken jwtSecurityToken = CreateJwtToken(Cliente);
            dataClienteDto.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            dataClienteDto.Email = Cliente.Email;
            dataClienteDto.ClienteName = Cliente.Clientename;
            dataClienteDto.Roles = Cliente.Rols
                                            .Select(u => u.Nombre)
                                            .ToList();

            if (Cliente.RefreshTokens.Any(a => a.IsActive))
            {
                var activeRefreshToken = Cliente.RefreshTokens.Where(a => a.IsActive == true).FirstOrDefault();
                dataClienteDto.RefreshToken = activeRefreshToken.Token;
                dataClienteDto.RefreshTokenExpiration = activeRefreshToken.Expires;
            }
            else
            {
                var refreshToken = CreateRefreshToken();
                dataClienteDto.RefreshToken = refreshToken.Token;
                dataClienteDto.RefreshTokenExpiration = refreshToken.Expires;
                Cliente.RefreshTokens.Add(refreshToken);
                _unitOfWork.Clientes.Update(Cliente);
                await _unitOfWork.SaveAsync();
            }

            return dataClienteDto;
        }
        dataClienteDto.IsAuthenticated = false;
        dataClienteDto.Message = $"Credenciales incorrectas para el usuario {Cliente.Clientename}.";
        return dataClienteDto;
    }
    public async Task<string> AddRoleAsync(AddRoleDto model)
    {

        var Cliente = await _unitOfWork.Clientes
                    .GetByClientenameAsync(model.Clientename);
        if (Cliente == null)
        {
            return $"Cliente {model.Clientename} does not exists.";
        }

        var result = _passwordHasher.VerifyHashedPassword(Cliente, Cliente.Password, model.Password);

        if (result == PasswordVerificationResult.Success)
        {
            var rolExists = _unitOfWork.Roles
                                        .Find(u => u.Nombre.ToLower() == model.Role.ToLower())
                                        .FirstOrDefault();

            if (rolExists != null)
            {
                var ClienteHasRole = Cliente.Rols
                                            .Any(u => u.Id == rolExists.Id);

                if (ClienteHasRole == false)
                {
                    Cliente.Rols.Add(rolExists);
                    _unitOfWork.Clientes.Update(Cliente);
                    await _unitOfWork.SaveAsync();
                }

                return $"Role {model.Role} added to Cliente {model.Clientename} successfully.";
            }

            return $"Role {model.Role} was not found.";
        }
        return $"Invalid Credentials";
    }
    public async Task<DataClienteDto> RefreshTokenAsync(string refreshToken)
    {
        var dataClienteDto = new DataClienteDto();

        var usuario = await _unitOfWork.Clientes
                        .GetByRefreshTokenAsync(refreshToken);

        if (usuario == null)
        {
            dataClienteDto.IsAuthenticated = false;
            dataClienteDto.Message = $"Token is not assigned to any Cliente.";
            return dataClienteDto;
        }

        var refreshTokenBd = usuario.RefreshTokens.Single(x => x.Token == refreshToken);

        if (!refreshTokenBd.IsActive)
        {
            dataClienteDto.IsAuthenticated = false;
            dataClienteDto.Message = $"Token is not active.";
            return dataClienteDto;
        }
        //Revoque the current refresh token and
        refreshTokenBd.Revoked = DateTime.UtcNow;
        //generate a new refresh token and save it in the database
        var newRefreshToken = CreateRefreshToken();
        usuario.RefreshTokens.Add(newRefreshToken);
        _unitOfWork.Clientes.Update(usuario);
        await _unitOfWork.SaveAsync();
        //Generate a new Json Web Token
        dataClienteDto.IsAuthenticated = true;
        JwtSecurityToken jwtSecurityToken = CreateJwtToken(usuario);
        dataClienteDto.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        dataClienteDto.Email = usuario.Email;
        dataClienteDto.ClienteName = usuario.Clientename;
        dataClienteDto.Roles = usuario.Rols
                                        .Select(u => u.Nombre)
                                        .ToList();
        dataClienteDto.RefreshToken = newRefreshToken.Token;
        dataClienteDto.RefreshTokenExpiration = newRefreshToken.Expires;
        return dataClienteDto;
    }
    private RefreshToken CreateRefreshToken()
    {
        var randomNumber = new byte[32];
        using (var generator = RandomNumberGenerator.Create())
        {
            generator.GetBytes(randomNumber);
            return new RefreshToken
            {
                Token = Convert.ToBase64String(randomNumber),
                Expires = DateTime.UtcNow.AddDays(10),
                Created = DateTime.UtcNow
            };
        }
    }
    private JwtSecurityToken CreateJwtToken(Cliente usuario)
    {
        var roles = usuario.Rols;
        var roleClaims = new List<Claim>();
        foreach (var role in roles)
        {
            roleClaims.Add(new Claim("roles", role.Nombre));
        }
        var claims = new[]
        {
                                new Claim(JwtRegisteredClaimNames.Sub, usuario.Clientename),
                                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                                new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
                                new Claim("uid", usuario.Id.ToString())
                        }
        .Union(roleClaims);
        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
        var jwtSecurityToken = new JwtSecurityToken(
            issuer: _jwt.Issuer,
            audience: _jwt.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_jwt.DurationInMinutes),
            signingCredentials: signingCredentials);
        return jwtSecurityToken;
    }

} */