using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/q3/[controller]")]
    [ApiController]
    public class CubeController : ControllerBase
    {
        /// <summary>
        /// This end point receives a number as a part of the URL and outputs the cube of that number as a response
        /// </summary>
        /// <param name="num">an integer number</param>
        /// <returns>The cube of the number received</returns>
        /// <example>
        /// GET localhost:7274/api/q3/cube/4 -> 64
        /// GET localhost:7274/api/q3/cube/-4 -> -64
        /// GET localhost:7274/api/q3/cube/10 -> 1000
        /// </example>
        [HttpGet(template:"{num}")]

        public int GetCube(int num)
        {
            return num * num * num;
        }
    }
}
