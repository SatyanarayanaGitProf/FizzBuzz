namespace FizzBuzz.Models
{
    public class DivisorModel
    {
        public DivisorModel(int divisor, string text)
        {
            Divisor = divisor;
            Text = text;
        }

        public int Divisor { get; set; }
        public string Text { get; set; }
    }
}
