using FizzBuzz.Models;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        private readonly IEvaluator _evaluator;

        public FizzBuzzController(IEvaluator evaluator)
        {
            _evaluator = evaluator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FizzBuzz(string fizzBuzz)
        {
            var response = _evaluator.Evaluate(fizzBuzz.Split(',').ToList());
            return View(response);
        }

    }
}
