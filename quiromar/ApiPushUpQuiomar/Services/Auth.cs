/* using System.Net;
using System.Net.Mail;
using Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TwoFactorAuthNet;
using TwoFactorAuthNet.Providers.Qr;

namespace API.Services;

public class Auth : IAuth
    {
        private readonly IPasswordHasher<Cliente> _passwordHasher;
        private readonly IConfiguration _conf;
        private readonly ILogger<Auth> _logger;
        public Auth
        (
            IPasswordHasher<Cliente> passwordHasher,
            IConfiguration conf ,
            ILogger<Auth> logger
        )
        {
            _conf = conf;
            _passwordHasher = passwordHasher;
            _logger = logger;  
        }

        public byte[] CreateQR(ref Cliente Cliente)
        {        
            if(Cliente.Email == null)
            {
                throw new ArgumentNullException(Cliente.Email);
            }        
            var tsa = new TwoFactorAuth(_conf["JWTSettings:Issuer"],6,30,Algorithm.SHA256, new ImageChartsQrCodeProvider());
            string secret = tsa.CreateSecret(160);
            Cliente.TwoStepSecret = secret;
            var QR = tsa.GetQrCodeImageAsDataUri(Cliente.Email, Cliente.TwoStepSecret); 
            string UriQR = QR.Replace("data:image/png;base64,", "");
            return Convert.FromBase64String(UriQR);        
        }

        public bool VerifyCode(string secret, string code){        
            var tsa = new TwoFactorAuth(_conf["JWTSettings:Issuer"],6,30,Algorithm.SHA256);
            return tsa.VerifyCode(secret, code, 1);
        }

        public async Task SendEmail(Cliente Cliente, byte[] QR)
        {
            try
            {
                var Email = new MailMessage
                {
                    From = new MailAddress(_conf.GetSection("InfoEmail:ClienteName").Value),
                    Subject = "Código QR de verificación en dos pasos"
                };

                Email.To.Add(new MailAddress(Cliente.Email));

                var ArchivoQR = new Attachment(new MemoryStream(QR), "qrcode.png");

                Email.Attachments.Add(ArchivoQR);

                await Task.Run(() =>
                {
                    var ConfigEmail = new SmtpClient
                    {
                        Host = _conf.GetSection("InfoEmail:Host").Value,
                        Port = int.Parse(_conf.GetSection("InfoEmail:Port").Value),
                        Credentials = new NetworkCredential(_conf.GetSection("InfoEmail:ClienteName").Value, _conf.GetSection("InfoEmail:Password").Value),
                        EnableSsl = true,
                    };

                    ConfigEmail.Send(Email);
                });

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hubo un error en el envío del correo: {ex.Message}");
            }
        }




} */