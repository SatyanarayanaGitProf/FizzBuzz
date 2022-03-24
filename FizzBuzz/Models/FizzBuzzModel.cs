namespace FizzBuzz.Models
{
    public class FizzBuzzModel
    {
        public FizzBuzzModel(string input, string output)
        {
            Input = input;
            Output = output;
        }

        public string Input { get; set; }

        public string Output { get; set; }
    }
}
