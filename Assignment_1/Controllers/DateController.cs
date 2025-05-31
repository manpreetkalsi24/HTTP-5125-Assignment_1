using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/q7")]
    [ApiController]
    public class DateController : ControllerBase
    {
        /// <summary>
        /// Returns date after adjusting days
        /// </summary>
        /// <param name="days">Number of days</param>
        /// <returns>Adjusted date string</returns>
        /// <example>GET /api/q7/timemachine?days=1</example>
        [HttpGet("timemachine")]
        public string GetTimeMachine([FromQuery] int days)
        {
            return DateTime.Today.AddDays(days).ToString("yyyy-MM-dd");
        }
    }
}
