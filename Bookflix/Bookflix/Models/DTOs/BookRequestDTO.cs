using System.ComponentModel.DataAnnotations;

namespace Bookflix.Models.DTOs
{
    public class BookRequestDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public DateTime DatePublished { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public float Score { get; set; }

    }
}
