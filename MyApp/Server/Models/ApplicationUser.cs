using Microsoft.AspNetCore.Identity;

namespace MyApp.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
        public string Token { get; set; } 
        public bool isAdmin { get; set; }

    }
}