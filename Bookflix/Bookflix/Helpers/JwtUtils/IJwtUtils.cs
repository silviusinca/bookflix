using Bookflix.Models;

namespace Bookflix.Helpers.JwtUtils
{
    public interface IJwtUtils
    {
        public Guid ValidateJwtToken(string token);
        public string GenerateJwtToken(User user);
    }
}
