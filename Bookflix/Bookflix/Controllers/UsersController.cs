using Bookflix.Models.DTOs.UserDTOs;
using Bookflix.Models.Enums;
using Bookflix.Models;
using Bookflix.Services.UserServices;
using Microsoft.AspNetCore.Mvc;
using Bookflix.Helpers.Attributes;

namespace Bookflix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser(UserRequestDTO user)
        {
            var userToCreate = new User
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = Role.USER,
                Email = user.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password)
            };

            await _userService.Create(userToCreate);
            return Ok();
        }

        [HttpPost("create-admin")]
        public async Task<IActionResult> CreateAdmin(UserRequestDTO user)
        {
            var userToCreate = new User
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = Role.ADMIN,
                Email = user.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password)
            };

            await _userService.Create(userToCreate);
            return Ok();
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(UserRequestDTO user)
        {
            var response = _userService.Authenticate(user);
            if (response == null)
            {
                return BadRequest("Invalid username or password!");
            }
            return Ok();
        }

        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] UserRequestDTO user)
        {
            var userToUpdate = _userService.GetById(id);
            if (userToUpdate == null)
            {
                return BadRequest("The book ID was not found!");
            }
            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Email = user.Email;
            _userService.Save();
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            var userToDelete = _userService.GetById(id);
            if (userToDelete == null)
            {
                return BadRequest("The book ID was not found!");
            }
            _userService.Delete(userToDelete);
            _userService.Save();
            return Ok();
        }


    }
}