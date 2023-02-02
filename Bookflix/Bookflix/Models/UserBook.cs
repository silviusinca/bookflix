using Bookflix.Models.Base;

namespace Bookflix.Models
{
    public class UserBook : BaseEntity
    {
        public Guid UserID { get; set; }
        public Guid BookID { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
