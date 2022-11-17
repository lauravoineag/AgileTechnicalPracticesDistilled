namespace RomanNumerals;

public class Numerals
{
    public string Convert(int number)
    {
        if (number < 4)
        {
            return new ('I', number);
        }
        return number == 4 ? "IV" : "V";
    } 
}