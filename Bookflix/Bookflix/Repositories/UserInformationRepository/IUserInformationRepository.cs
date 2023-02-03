using Bookflix.Models;
using Bookflix.Repositories.GenericRepository;

namespace Bookflix.Repositories.UserInformationRepository
{
    public interface IUserInformationRepository : IGenericRepository<UserInformation>
    {
        UserInformation GetInfoByUsername(string username);
    }
}
