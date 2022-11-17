namespace FIzzBUzz;

//5
public class FizzBuzz
{
    public string Execute(int number)
    {
        if (number == 3)
        {
            return "Fizz";
        }

        if (number == 5)
        {
            return "Buzz";
        }

        if (number == 15)
        {
            return number.ToString();
        }

        return default;
    }
}