using Bookflix.Models.Base;

namespace Bookflix.Models
{
    public class UserInformation : BaseEntity
    {
        public Guid UserID { get; set; }
        public User? User { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        // de astea nu s sigur
        public static int NO_BOOKS_REVIEWED { get; set; }
        public static int NO_BOOKS_READ { get; set; }
    }
}
