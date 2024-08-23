using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {

        public CommandController()
        {
        }

        [HttpGet]
        public ActionResult TestInbound()
        {
            Console.WriteLine("--> Inbound GET # Command Service");
            return Ok("Inbound test of from Command Controller");
        }

        [HttpPost]
        public ActionResult TestInbound(string body)
        {
            Console.WriteLine("--> Inbound POST # Command Service");
            return Ok("Inbound test of from Platforms Controller");
        }
    }
}