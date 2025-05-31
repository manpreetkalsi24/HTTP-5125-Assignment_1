using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/q6")]
    [ApiController]
    public class HexagonController : ControllerBase
    {
        /// <summary>
        /// it calculates the area of hexagon
        /// </summary>
        /// <param name="side">side length</param>
        /// <returns> area of hexagon</returns>
        /// <example>
        /// localhost:7274/api/q6/hexagon?side=1
        /// localhost:7274/api/q6/hexagon?side=1.5
        /// </example>
        
        [HttpGet("hexagon")]
        public double GetHexagonArea([FromQuery] double side)
        {
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side,2);
            return area;
        }
    }
}
