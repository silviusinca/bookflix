using Bookflix.Models.Base;

namespace Bookflix.Models
{
    public class Review : BaseEntity
    {
        public string Title { get; set; }
        public string Message { get; set; }
        
        // value should be between 1.0 and 5.0
        public float Stars { get; set; }
    }
}
