namespace FizzBuzz.Models
{
    public class FizzBuzzEvaluatorModel
    {
        public FizzBuzzEvaluatorModel()
        {
            FizzBuzz = new List<FizzBuzzModel>();
        }

        public FizzBuzzEvaluatorModel(List<FizzBuzzModel> fizzBuzz)
        {
            FizzBuzz = fizzBuzz;
        }

        public List<FizzBuzzModel> FizzBuzz { get; set; }
    }
}
