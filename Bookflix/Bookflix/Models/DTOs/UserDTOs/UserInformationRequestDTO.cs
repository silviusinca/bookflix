using System.ComponentModel.DataAnnotations;

namespace Bookflix.Models.DTOs.UserDTOs
{
    public class UserInformationRequestDTO
    {
        [Required]
        public Guid UserID { get; set; }
        public User User { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int NO_BOOKS_REVIEWED { get; set; }
        public int NO_BOOKS_READ { get; set; }
    }
}
