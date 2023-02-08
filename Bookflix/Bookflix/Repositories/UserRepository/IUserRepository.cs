using Bookflix.Models;
using Bookflix.Repositories.GenericRepository;

namespace Bookflix.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByUsername(string username);
        ICollection<User> FindAll();

        Task<IEnumerable<User>> FindAllWithAtLeastThreeBooksReviewd();
    }
}
