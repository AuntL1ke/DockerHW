using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppWithDockerHW09.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            object[] users =
            {
                new { Name = "Oleg" },
                new { Name = "Ivan" }
            };

            return Ok(users);
        }
    }
}
