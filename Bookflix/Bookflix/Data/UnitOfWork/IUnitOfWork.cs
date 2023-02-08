using Bookflix.Repositories.UserRepository;

namespace Bookflix.Data
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> SaveAsync();
    }

}
