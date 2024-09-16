/* using API.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

[ApiVersion("1.0")]
[ApiVersion("1.1")]


public class ClienteController : BaseApiController
{
    private readonly IClienteService _ClienteService;
    private readonly IUnitOfWork unitofwork;
    private readonly IMapper mapper;
     private readonly ILogger<ClienteController> logger;
     private readonly IAuth auth;
     private readonly IPasswordHasher<Cliente> _passwordHasher;

    public ClienteController(IClienteService ClienteService, IUnitOfWork unitofwork, IMapper mapper, IAuth auth,ILogger<ClienteController> logger, IPasswordHasher<Cliente> passwordHasher)
    {
        _ClienteService = ClienteService;
        this.unitofwork = unitofwork;
        this.mapper = mapper;
        this.logger = logger;
        this.auth = auth;
         _passwordHasher = passwordHasher;
        

    }

    [HttpGet]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<ClienteDto>>> Get()
    {
        var entidad = await unitofwork.Clientes.GetAllAsync();
        return mapper.Map<List<ClienteDto>>(entidad);
    }


    // [HttpGet]
    // [MapToApiVersion("1.1")]
    // [ProducesResponseType(StatusCodes.Status200OK)]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<Pager<ClienteDto>>> GetPaginacion([FromQuery] Params usuarioParams)
    // {
    //     var entidad = await unitofwork.Clientes.GetAllAsync(usuarioParams.PageIndex, usuarioParams.PageSize, usuarioParams.Search);
    //     var listEntidad = mapper.Map<List<ClienteDto>>(entidad.registros);
    //     return new Pager<ClienteDto>(listEntidad, entidad.totalRegistros, usuarioParams.PageIndex, usuarioParams.PageSize, usuarioParams.Search);
    // }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ClienteDto>> Get(int id)
    {
        var entidad = await unitofwork.Clientes.GetByIdAsync(id);
        if (entidad == null)
        {
            return NotFound();
        }
        return this.mapper.Map<ClienteDto>(entidad);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ClienteDto>> Put(int id, [FromBody] ClienteDto entidadDto)
    {
        if (entidadDto == null)
        {
            return NotFound();
        }
        var entidad = this.mapper.Map<Cliente>(entidadDto);
        unitofwork.Clientes.Update(entidad);
        await unitofwork.SaveAsync();
        return entidadDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var entidad = await unitofwork.Clientes.GetByIdAsync(id);
        if (entidad == null)
        {
            return NotFound();
        }
        unitofwork.Clientes.Remove(entidad);
        await unitofwork.SaveAsync();
        return NoContent();
    }


    [HttpPost("Register")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult> RegisterAsync(RegisterDto model)
    {
        var result = await _ClienteService.RegisterAsync(model);
        return Ok(result);
    }


    [HttpPost("Login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Login([FromBody] LoginDto data)
    {
        
            Cliente Cliente =  await unitofwork.Clientes.GetByClientenameAsync(data.Clientename);

            if (Cliente == null)
            {
                return BadRequest("Usuario no válido.");
            }

            var result = _passwordHasher.VerifyHashedPassword(Cliente, Cliente.Password, data.Password);

            if (result == PasswordVerificationResult.Success)
            {

            byte[] QR = auth.CreateQR(ref Cliente);
            unitofwork.Clientes.Update(Cliente);
            await unitofwork.SaveAsync();

            // Realizar la autenticación y obtener el token
            DataClienteDto tokenData = await _ClienteService.GetTokenAsync(data);
            SetRefreshTokenInCookie(tokenData.RefreshToken);

            // Envía el correo electrónico con el QR
            await auth.SendEmail(Cliente, QR);

            return Ok(tokenData);
            }
            else
            {
                return BadRequest("Error, se produjo un error durante la autenticación.");
            }
    }




    [HttpPost("addrole")]
    public async Task<IActionResult> AddRoleAsync(AddRoleDto model)
    {
        var result = await _ClienteService.AddRoleAsync(model);
        return Ok(result);
    }



    [HttpPost("refresh-token")]
    public async Task<IActionResult> RefreshToken()
    {
        var refreshToken = Request.Cookies["refreshToken"];
        var response = await _ClienteService.RefreshTokenAsync(refreshToken);
        if (!string.IsNullOrEmpty(response.RefreshToken))
            SetRefreshTokenInCookie(response.RefreshToken);
        return Ok(response);
    }



    [HttpPost("VerifyCode")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]    
        [ProducesResponseType(StatusCodes.Status400BadRequest)]    
        public async Task<ActionResult> Verify([FromBody] AuthDto data)
        {        
            try
            {
                Cliente u = await unitofwork.Clientes.FindFirst(p => p.Clientename == data.Clientename);
                if(u.TwoStepSecret == null)
                {
                    throw new ArgumentNullException(u.TwoStepSecret);
                }
                var isVerified = auth.VerifyCode(u.TwoStepSecret, data.Code);            

                if(isVerified == true)
                {
                    return Ok("authenticated, checked");
                }
                return Unauthorized();

            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return BadRequest("error, some error occurred");
            }                        
        }


    private void SetRefreshTokenInCookie(string refreshToken)
    {
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = DateTime.UtcNow.AddDays(10),
        };
        Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
    }

    
    
} */