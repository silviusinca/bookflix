using System.ComponentModel.DataAnnotations;

namespace Bookflix.Models.DTOs
{
    public class ReviewRequestDTO
    {
        [Required]
        public Guid UserID { get; set; }
        [Required]
        public Guid BookID { get; set; }
        public string Title { get; set; }
        public string? Message { get; set; }
        public float Rating { get; set; }
    }
}
