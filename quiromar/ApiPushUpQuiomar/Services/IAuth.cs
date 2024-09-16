using Domain.Entities;

namespace API.Services;

public interface IAuth
    {
        byte[] CreateQR(ref Cliente Cliente);
        bool VerifyCode(string secret, string code);
        Task SendEmail(Cliente Cliente, byte[] QR);
    }