using Microsoft.AspNetCore.Identity;
using ProjectEweis.Models;
using System.ComponentModel.DataAnnotations;

namespace TestApiJWT.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50),Phone]
        public string PhoneNumber { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}