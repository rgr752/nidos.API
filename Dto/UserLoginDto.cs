using System.ComponentModel.DataAnnotations;

namespace nidos.API.Dto
{
    public class UserLoginDto
    {
        public string Username { get; set; }
        
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}