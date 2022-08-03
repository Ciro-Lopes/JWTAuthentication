using JWTAuthentication.Authorization;
using JWTAuthentication.Entities;
using JWTAuthentication.Models;
using JWTAuthentication.Services;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthentication.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Insert(UserPostRequest user)
        {
            var users = _userService.Insert(new User() 
            { 
                Username = user.Username, 
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password),
            });
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}