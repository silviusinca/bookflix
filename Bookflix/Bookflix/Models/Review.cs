using Bookflix.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Bookflix.Models
{
    public class Review : BaseEntity
    {
        public Guid UserID { get; set; }
        public Guid BookID { get; set; }
        public string Title { get; set; } 
        public string? Message { get; set; }
        
        // value should be between 1.0 and 5.0
        public float Rating { get; set; }
    }
}
