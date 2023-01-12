namespace RomanNumerals;

public class Numerals
{
    public string Convert(int number)
    {
        if (number < 4)
        {
            return new ('I', number);
            //string constructor - returns a string with character * repeated n times
        }
        return number == 4 ? "IV" : "V"; //ternary operator
    } 
}