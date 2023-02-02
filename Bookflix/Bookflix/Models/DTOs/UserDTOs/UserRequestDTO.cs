using System.ComponentModel.DataAnnotations;

namespace Bookflix.Models.DTOs.UserDTOs
{
    public class UserRequestDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public UserInformation UserInformation { get; set; }
    }
}
