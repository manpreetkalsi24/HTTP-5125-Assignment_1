using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/q5")]
    [ApiController]
    public class AcknowledgementController : ControllerBase
    {
        /// <summary>
        /// Accepts a secret number in the request body and returns a message.
        /// </summary>
        /// <param name="secret">The secret number</param>
        /// <returns>Returns a string acknowledging the secret</returns>
        /// <example>
        /// POST /api/q5/secret with body: 5
        /// POST /api/q5/secret with body: -200
        /// </example>
        [HttpPost("secret")]
        public string PostSecret([FromBody]int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
