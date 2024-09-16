using System.ComponentModel.DataAnnotations;

namespace ApiPushUpEnviaBackend.Dtos;

public class AuthDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Code { get; set; }

}