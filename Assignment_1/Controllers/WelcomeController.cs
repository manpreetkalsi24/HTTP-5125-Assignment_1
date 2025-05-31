using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/q1/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message 
        /// </summary>
        /// <returns>String Welcome to 5125!</returns>
        /// <example>GET http://localhost:xx/api/q1/welcome</example>
        [HttpGet]
        public string Get()
        {
            return "Welcome to 5125!";
        }
    }
}
