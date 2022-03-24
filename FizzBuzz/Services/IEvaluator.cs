using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public interface IEvaluator
    {
        FizzBuzzEvaluatorModel Evaluate(List<string> inputs);
    }
}
