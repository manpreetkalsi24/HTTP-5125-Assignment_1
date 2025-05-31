using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/q8")]
    [ApiController]
    public class SquashController : ControllerBase
    {
        /// <summary>
        /// Checkout calculation for SquashFellows order
        /// </summary>
        /// <param name="Small">Small units</param>
        /// <param name="Large">Large units</param>
        /// <returns>Summary string</returns>
        /// <example>POST /api/q8/squashfellows</example>
        [HttpPost("squashfellows")]
        public string PostOrder([FromForm] int Small, [FromForm] int Large)
        {
            double smallPrice = 25.5;
            double largePrice = 40.5;
            double subtotal = (Small * smallPrice) + (Large * largePrice);
            double tax = Math.Round(subtotal * 0.13, 2);
            double total = Math.Round(subtotal + tax, 2);

            return $"{Small} Small @ ${smallPrice} = ${Small * smallPrice:0.00}; " +
                   $"{Large} Large @ ${largePrice} = ${Large * largePrice:0.00}; " +
                   $"Subtotal = ${subtotal:0.00}; Tax = ${tax:0.00} HST; Total = ${total:0.00}";
        }
    }
}
