using Bookflix.Models.Base;
using Bookflix.Models.Enums;

namespace Bookflix.Models
{
    public class Book : BaseEntity
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePublished { get; set; }
        public ICollection<UserBook> UserBooks { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        // media review-urilor
        public float? Score { get; set; }
    }
}
