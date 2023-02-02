using System.ComponentModel.DataAnnotations;

namespace Bookflix.Models.DTOs
{
    public class UserBookRequest
    {
        [Required]
        public Guid UserID { get; set; }
        [Required]
        public Guid BookID { get; set; }
    }
}
