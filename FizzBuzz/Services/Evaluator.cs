using FizzBuzz.Models;
using System.Text;

namespace FizzBuzz.Services
{
    public class Evaluator : IEvaluator
    {
        private readonly IValidator _validator;
        private readonly IEvaluatorProcessor _evaluatorProcessor;

        public Evaluator(IValidator validator, IEvaluatorProcessor evaluatorProcessor)
        {
            _validator = validator;
            _evaluatorProcessor = evaluatorProcessor;
        }
        public FizzBuzzEvaluatorModel Evaluate(List<string> inputs)
        {
            var response = new List<FizzBuzzModel>();
            var divisors = GetDivisors();
            foreach (var input in inputs)
            {
                if (_validator.IsValid(input))
                {
                    string output = _evaluatorProcessor.Evaluate(Convert.ToInt32(input), divisors);
                    response.Add(new FizzBuzzModel(input, output));
                }
                else
                {
                    response.Add(new FizzBuzzModel(input, "Invalid Item"));
                }
            }
            return new FizzBuzzEvaluatorModel(response);
        }

        private List<DivisorModel> GetDivisors()
        {
            var divisors = new List<string>() { "3:Fizz", "5:Buzz" };

            return divisors.Select(_ =>
            {
                DivisorModel divisorModel = new DivisorModel(Convert.ToInt32(_.Split(":")[0]), _.Split(":")[1]);
                return divisorModel;
            }).ToList();
        }
    }
}
