using Bookflix.Data;
using Bookflix.Models;
using Bookflix.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Bookflix.Repositories.UserInformationRepository
{
    public class UserInformationRepository : GenericRepository<UserInformation>, IUserInformationRepository
    {
        public UserInformationRepository(BookflixContext context) : base(context)
        {
        }
        public UserInformation GetInfoByUsername(string username)
        {
            return _table.FirstOrDefault(info => info.User.Username == username);
        }
    }
}
