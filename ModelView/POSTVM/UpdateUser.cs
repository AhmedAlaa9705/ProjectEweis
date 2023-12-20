using System.ComponentModel.DataAnnotations;

namespace ProjectEweis.ModelView.POSTVM
{
    public class UpdateUser
    {
        [Required]
        public string UserId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
