//Get user Input
using System;
namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username");
            string userName = Console.ReadLine();
            Console.WriteLine("Your Username is :: " + ' ' + userName);
            Console.WriteLine("Enter your Age");
            // Console.readline always inputs string data so we have to externally convert it to the desired user type
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is : " + ' ' + age);
            // Note: If you enter wrong input (e.g. text in a numerical input), you will get an exception/error message (like System.FormatException: 'Input string was not in a correct format.').
        }
    }
}
