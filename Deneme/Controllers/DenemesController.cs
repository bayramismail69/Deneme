using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Gel(string path)
        {
            return Ok("Deneme: "+path);
        }
    }
}
