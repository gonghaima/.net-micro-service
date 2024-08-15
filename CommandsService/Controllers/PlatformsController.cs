using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {

        public PlatformsController()
        {
        }

        [HttpGet]
        public ActionResult TestInbound()
        {
            Console.WriteLine("--> Inbound GET # Command Service");
            return Ok("Inbound test of from Platforms Controller");
        }

        [HttpPost]
        public ActionResult TestInbound(string body)
        {
            Console.WriteLine("--> Inbound POST # Command Service");
            return Ok("Inbound test of from Platforms Controller");
        }
    }
}