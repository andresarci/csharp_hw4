using static System.Console;
namespace CheckDigit;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Please insert your 4 digits account number");
        int AccountNumber = Convert.ToInt32(ReadLine());
        int FirstThree = AccountNumber / 10;
        int LastDigit = AccountNumber % 10;
        int reminder = FirstThree % 7;
        if (LastDigit == reminder)
        {
            WriteLine("Your account number is valid");
        }
        else
        {
            WriteLine("Invalid");
        }
    }
}
 