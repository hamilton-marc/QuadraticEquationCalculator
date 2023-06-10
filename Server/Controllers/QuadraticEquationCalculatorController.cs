using Microsoft.AspNetCore.Mvc;
using QuadraticEquationCalculator.Shared;
using System.Numerics;

namespace QuadraticEquationCalculator.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuadraticEquationCalculatorController : ControllerBase
    {
        private readonly ILogger<QuadraticEquationCalculatorController> _logger;

        public QuadraticEquationCalculatorController(ILogger<QuadraticEquationCalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ValueTuple<Complex, Complex> Get()
        {
            return new ValueTuple<Complex, Complex>(0, 0);
        }
    }
}