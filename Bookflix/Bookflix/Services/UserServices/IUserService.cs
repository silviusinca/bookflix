using Bookflix.Models;
using Bookflix.Models.DTOs.UserDTOs;

namespace Bookflix.Services.UserServices
{
    public interface IUserService
    {
        UserResponseDTO Authenticate(UserRequestDTO model);
        User GetById(Guid id);
        Task Create(User newUser);
        Task<List<User>> GetAllUsers();
        Task Delete(User userToDelete);
        Task Update(User userToUpdate);
        bool Save();
    }
}
