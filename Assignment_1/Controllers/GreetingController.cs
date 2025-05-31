using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/q2/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        ///<summary>Greets the provided name</summary>
        ///<param name="name">The user's name</param>
        ///<returns>Returns a greeting to {name}</returns>
        ///<example>GET http://localhost:xx/api/q2/greeting?name={name}</example>
        [HttpGet]
        public string GetGreeting([FromQuery] string name)
        {
            return $"Hi {name}!";
        }

    }
}
