using System.ComponentModel.DataAnnotations.Schema;
using TestApiJWT.Models;

namespace ProjectEweis.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public DateTime When { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser AppUser { get; set; }
    }
}
