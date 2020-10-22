using System;

namespace UserInputAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Inputs
            //Type your username and press enter
            Console.WriteLine("Enter username");

            //Create a string variable and get user input from the keyboard and stroe it in the variable
            string userName = Console.ReadLine();

            //Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            //User Inputs and numbers
            Console.WriteLine("Enter your age");
            //int age = Console.ReadLine(); //Will Throw an error
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            /*Operators*/
            int x = 100 + 50;

            int sum1 = 100 + 50;    // 150 (100 + 50)
            int sum2 = sum1 + 250;  // 400 (150 + 250)
            int sum3 = sum2 + sum2; // 800 (400 + 400)
        }
    }
}
