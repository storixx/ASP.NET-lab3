using Microsoft.AspNetCore.Mvc;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArithmeticController : ControllerBase
    {
        private readonly CalcService _calcService;
        private readonly TimeService _timeService;

        public ArithmeticController(CalcService calcService, TimeService timeService)
        {
            _calcService = calcService;
            _timeService = timeService;
        }

        [HttpGet("add")]
        public IActionResult Add(int a, int b) => Ok(_calcService.Add(a, b));

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b) => Ok(_calcService.Subtract(a, b));

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b) => Ok(_calcService.Multiply(a, b));

        [HttpGet("divide")]
        public IActionResult Divide(int a, int b) => Ok(_calcService.Divide(a, b));
        
        [HttpGet("timeOfDay")]
        public IActionResult GetTimeOfDay() => Ok(_timeService.GetTimeOfDay());
    }
}
