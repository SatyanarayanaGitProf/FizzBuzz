namespace FizzBuzz.Services
{
    public class Validator : IValidator
    {
        public bool IsValid(string input)
        {
            return string.IsNullOrWhiteSpace(input) || short.TryParse(input, out short output);
        }
    }
}
