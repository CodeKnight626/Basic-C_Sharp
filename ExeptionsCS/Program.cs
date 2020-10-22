using System;

namespace ExeptionsCS
{
    /*C# Exceptions*/
    class Program
    {
        /*Throw keyword*/
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied -  You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            /*Try and catch exceptions*/
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]); //error!
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // Output my own error message
                Console.WriteLine("Something went wrong.");
            }
            //Finaly statement will execute regardless of the result
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            checkAge(15);
        }
    }
}
