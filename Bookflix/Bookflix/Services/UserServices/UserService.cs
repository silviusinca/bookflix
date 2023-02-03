using Bookflix.Helpers.JwtUtils;
using Bookflix.Models;
using Bookflix.Models.DTOs.UserDTOs;
using Bookflix.Repositories.UserRepository;

namespace Bookflix.Services.UserServices
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IJwtUtils _jwtUtils;

        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils)
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
        }   

        public UserResponseDTO Authenticate(UserRequestDTO model)
        {
            var user = _userRepository.FindByUsername(model.Username);
            if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
            {
                return null;
            }

            var token = _jwtUtils.GenerateJwtToken(user);
            return new UserResponseDTO(user, token);
        }

        public Task Create(UserRequestDTO newUser)
        {
            throw new NotImplementedException();
        }

        public void Delete(User userToDelete)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserRequestDTO GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void Update(User userToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
