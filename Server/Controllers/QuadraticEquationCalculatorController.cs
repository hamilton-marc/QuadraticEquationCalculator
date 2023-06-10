using Microsoft.AspNetCore.Mvc;
using QuadraticEquationCalculator.Server.Services;
using QuadraticEquationCalculator.Shared;
using System.Numerics;

namespace QuadraticEquationCalculator.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuadraticEquationCalculatorController : ControllerBase
    {
        private readonly ILogger<QuadraticEquationCalculatorController> _logger;
        private readonly IQuadraditicEquationCalculatorService _calculatorService;

        public QuadraticEquationCalculatorController(ILogger<QuadraticEquationCalculatorController> logger, IQuadraditicEquationCalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }

        [HttpGet]
        public ValueTuple<Complex, Complex> Get(double a, double b, double c)
        {
            var result = _calculatorService.CalculateQuadraticRoots(a, b, c);

            return result;
        }
    }
}