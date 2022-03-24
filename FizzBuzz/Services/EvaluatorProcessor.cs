using FizzBuzz.Models;
using System.Text;

namespace FizzBuzz.Services
{
    public class EvaluatorProcessor : IEvaluatorProcessor
    {
        public string Evaluate(int input, List<DivisorModel> divisors)
        {
            var response = new StringBuilder();
            foreach (var divisor in divisors)
            {
                if (Helper.IsDivideBy(input, divisor.Divisor))
                {
                    response.Append(divisor.Text);
                }
            }
            if (response.Length == 0)
            {
                divisors.ForEach(_ => response.Append($"Divided {input} By {_.Divisor} "));
            }

            return response.ToString();
        }
    }
}
