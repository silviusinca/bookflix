using Bookflix.Models.Base;
using Bookflix.Models.Enums;

namespace Bookflix.Models
{
    public class Book : BaseEntity
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<UserBook> UserBooks { get; set; }
        // media review-urilor
        public ICollection<Review>? Reviews { get; set; }
        public float? GradePointAverage { get; set; }
    }
}
