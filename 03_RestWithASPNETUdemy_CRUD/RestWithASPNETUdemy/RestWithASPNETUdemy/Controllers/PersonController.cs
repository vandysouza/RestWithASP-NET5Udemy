using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult  Get (string firstNumber, string secondNumber)
        {
           
            return BadRequest("Invalid Inoput");
        }

      

      
    }
}
