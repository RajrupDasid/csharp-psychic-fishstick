//variables in c#

using System;
using System.Reflection.PortableExecutable;
namespace Variables
{
    class Variable
    {
        static void Main(string[] args)
        {
            int myNum;
            myNum = 45;
            double dsp = 5.99D;
            bool mybool = true;
            char oneletter = 'D';
            // constants
            // values cannnot be change in runtime;
            const int extranumber = 0;
            /* 

            The const keyword is useful when you want a variable to always store the same value, so that others (or yourself) won't mess up your code. An example that is often referred to as a constant, is PI (3.14159...).

            Note: You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.
            */

            Console.WriteLine(myNum);
            Console.WriteLine("double" + ' ' + dsp); // string conncatination
            Console.WriteLine(mybool);
            Console.WriteLine(oneletter);
            Console.WriteLine(extranumber);

            // Display Varibles
            // The WriteLine() method is often used to display variable values to the console window.
            //To combine both text and a variable, use the + character:

            string name = "John";
            Console.WriteLine("Hello " + name);
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);


        }
    }
}