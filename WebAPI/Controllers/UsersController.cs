using Buisness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getclaims")]
        public IActionResult GetClaims(User user)
        {
            var claims = _userService.GetClaims(user);
            return Ok(claims);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return Ok("User added successfully");
        }

        [HttpGet("getbymail")]
        public IActionResult GetByMail(string mail)
        {
            var user = _userService.GetByMail(mail);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound("User not found");
        }
    }
}
