using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JWTRefreshTokenInDotNetCore9.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        public string FirstName { get; set; } = default!;

        [MaxLength(50)]
        public string LastName { get; set; } = default!;

        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}
