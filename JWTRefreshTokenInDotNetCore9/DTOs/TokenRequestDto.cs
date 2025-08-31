using System.ComponentModel.DataAnnotations;

namespace JWTRefreshTokenInDotNetCore9.DTOs
{
    public class TokenRequestDto
    {
        [EmailAddress]
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
