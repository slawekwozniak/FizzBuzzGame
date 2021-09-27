namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            string result = "";
            if (number % 3 == 0) result = "Fizz";
            if (number % 5 == 0) result = result + "Buzz";
            if (string.IsNullOrWhiteSpace(result)) result = number.ToString();

            return result;
        }
    }
}
