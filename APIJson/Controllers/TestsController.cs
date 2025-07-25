using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIJson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
      
        [HttpGet("public")]
        public IActionResult Public()
        {
            return Ok("Soy publico");
        }

        [HttpGet("private")]
        public IActionResult Private()
        {
            return Ok("Soy privado");
        }


        [HttpGet("token")]
        public IActionResult Token()
        {
            return Ok("Soy token");
        }

    }
}
