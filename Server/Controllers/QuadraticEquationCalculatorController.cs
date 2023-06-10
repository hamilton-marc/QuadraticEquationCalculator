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
        public QuadraticRoots Get(double a, double b, double c)
        {
            var roots = _calculatorService.CalculateQuadraticRoots(a, b, c);

            var result = new QuadraticRoots()
            {
                Root1 = new QuadraticRoot()
                {
                    Real = roots.Item1.Real,
                    Imaginary = roots.Item1.Imaginary
                },
                Root2 = new QuadraticRoot()
                {
                    Real = roots.Item2.Real,
                    Imaginary = roots.Item2.Imaginary
                }
            };

            return result;
        }
    }
}