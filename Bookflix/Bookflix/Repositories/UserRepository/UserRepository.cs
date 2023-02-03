using Bookflix.Data;
using Bookflix.Models;
using Bookflix.Repositories.GenericRepository;

namespace Bookflix.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(BookflixContext context) : base(context) { }

        public User FindByUsername(string username)
        {
            return _table.FirstOrDefault(x => x.Username == username);
        }
    }
}
