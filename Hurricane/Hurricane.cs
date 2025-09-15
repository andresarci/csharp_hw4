using static System.Console;
namespace Hurricane;

class Program
{
    static void Main()
    {
        WriteLine("Please insert the speed of the wind in mi/h");
        int speed = Convert.ToInt32(ReadLine());
        if (speed < 74)
        {
            WriteLine("Not a hurrcane yet");
        }
        else if (speed >= 74 && speed <= 95)
        {
            WriteLine("Category 1");
        }
        else if (speed >= 96 && speed <= 110)
        {
            WriteLine("Category 2");
        }
        else if (speed >= 111 && speed <= 129)
        {
            WriteLine("Category 3");
        }
        else if (speed >= 130 && speed <= 156)
        {
            WriteLine("Category 4");
        }
        else if (speed >= 157)
        {
            WriteLine("Category 5");
        }
    }
}
