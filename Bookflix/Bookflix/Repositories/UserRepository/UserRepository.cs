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

        public ICollection<User> FindAll()
        {
            return (ICollection<User>)_table.Join(_context.UsersInformation, user => user.ID, info => info.UserID,
                (user, info) => new { user, info }).Select(res => res.user);
        }

        public async Task<IEnumerable<User>> FindAllWithAtLeastThreeBooksReviewd()
        {
            return _table.Where(user => user.UserBooks.Count() >= 3);
        }
    }
}

