using Microsoft.AspNetCore.Mvc;

namespace ese01.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestApiController : ControllerBase
    {
        public IActionResult Get()
        {
            var pet = new { Age = 10, Name = "Fluffy" };
            return Ok(pet);
        }
    }
}