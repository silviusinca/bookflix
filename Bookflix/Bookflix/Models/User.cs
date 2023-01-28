using Bookflix.Models.Base;
using Bookflix.Models.Enums;
using System.Text.Json.Serialization;

namespace Bookflix.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public UserInformation UserInformation { get; set; }
        public ICollection<UserBook> UserBooks { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
        public Role Role { get; set; }
    }
}
