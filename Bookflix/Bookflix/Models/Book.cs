using Bookflix.Models.Base;

namespace Bookflix.Models
{
    public class Book : BaseEntity
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        // sa zicem ca poti adauga si website-ul autorului in caz ca are
        public string? AuthorUrl { get; set; }
        // media review-urilor
        public int? GradePointAverage { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
