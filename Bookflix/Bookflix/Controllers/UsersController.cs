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

        [Authorization(Role.ADMIN)]
        [HttpGet("admin")]
        public IActionResult GetAllAdmin()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [Authorization(Role.USER)]
        [HttpGet("user")]
        public IActionResult GetAllUser()
        {
            return Ok("User");
        }

    }
}