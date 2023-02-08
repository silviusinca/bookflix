﻿using Bookflix.Data;
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
        public IUnitOfWork _unitOfWork;

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

        public async Task Create(User newUser)
        {
            await _userRepository.CreateAsync(newUser);
            await _userRepository.SaveAsync();
        }

        public async Task Delete(User userToDelete)
        {
            _userRepository.Delete(userToDelete);
            await _unitOfWork.SaveAsync();

        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllAsync();
        }

        public bool Save()
        {
            return _userRepository.Save();
        }

        public async Task Update(User userToUpdate)
        {
            _userRepository.Update(userToUpdate);
            await _unitOfWork.SaveAsync();

        }
        public User GetById(Guid id)
        {
            return _userRepository.FindById(id);
        }
    }
}
