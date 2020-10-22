using System;

namespace stringsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*C# Strings*/
            string greeting = "Hello!";

            //String length
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the text string is: " + txt.Length);

            //Other Methods
            string otherTxt = "Hello World!";
            Console.WriteLine(otherTxt.ToUpper());
            Console.WriteLine(otherTxt.ToLower());

            /*
            //String Concatenation
            string firstName = "John ";
            string lastName = "Doe";

            string name = firstName + lastName;
            Console.WriteLine(name);
            */

            //String interpaolation
            string firstName = "John";
            string lastName = "Doe";

            string name = $"My full name is: {firstName} {lastName}";

            Console.WriteLine(name);

            //Access Srings
            string myString = "Hello";
            Console.WriteLine(myString[0]);

        }
    }
}
