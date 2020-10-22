using System;

namespace booleansCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*C# Booleans*/
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            int x = 10;
            Console.WriteLine(x == 10);
            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15
        }
    }
}
