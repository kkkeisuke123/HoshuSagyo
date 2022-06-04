using Microsoft.AspNetCore.Identity;

namespace HoshuSagyo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Kankatsu { get; set; }
    }
}
