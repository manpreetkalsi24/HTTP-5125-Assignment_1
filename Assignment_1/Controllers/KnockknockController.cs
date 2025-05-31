using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/q4/[controller]")]
    [ApiController]
    public class KnockknockController : ControllerBase
    {
        /// <summary>
        /// starts a knock knock joke
        /// </summary>
        /// <returns>Start of Joke line</returns>
        /// <example>GET localhost:7274/api/q4/knockknock</example>
        [HttpGet]
        public string KnocKnock()
        {
            return "Who's there?";
        }
    }
}
