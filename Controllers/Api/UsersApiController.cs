using ese01.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace ese01.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersApiController(IUsersService usersService) : ControllerBase
    {
        private readonly IUsersService _usersService = usersService;

        // GET api/usersapi
        public IActionResult Get()
        {
            return Ok(_usersService.GetAll());
        }

        // GET api/usersapi/allusers
        [HttpGet("AllUsers")]
        public IActionResult GetAllUsers()
        {
            return Ok(_usersService.GetAll());
        }

        // GET api/usersapi/3
        [HttpGet("{userId}")]
        // GET api/usersapi/user/3
        [HttpGet("User/{userId}")]
        public IActionResult GetUserDetail(int userId)
        {
            return Ok(_usersService.FindById(userId));
        }
    }
}