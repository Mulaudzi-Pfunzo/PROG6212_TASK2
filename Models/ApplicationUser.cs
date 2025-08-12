using Microsoft.AspNetCore.Identity;

namespace RegistrationSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Qualification { get; set; }
        public string Module { get; set; }
    }
}
