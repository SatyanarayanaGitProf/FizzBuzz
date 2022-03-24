using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public interface IEvaluatorProcessor
    {
        string Evaluate(int input, List<DivisorModel> divisors);
    }
}
