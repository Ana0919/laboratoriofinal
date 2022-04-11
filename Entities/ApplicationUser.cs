using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ApplicationUser
    {
       [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
