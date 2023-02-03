using Bookflix.Data;
using Bookflix.Models;
using Bookflix.Repositories.BookRepository;
using Bookflix.Repositories.GenericRepository;

namespace Bookflix.Repositories.UserBookRepository
{
    public class UserBookRepository : GenericRepository<UserBook>, IUserBookRepository
    {
        public UserBookRepository(BookflixContext context) : base(context)
        {
        }
    }
}
