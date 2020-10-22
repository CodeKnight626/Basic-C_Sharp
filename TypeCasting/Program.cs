using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //There are two types of casting, Implicit and explicit

            //Implicit(automatically) Convert a smaller type to a larger type size
            //char -> int -> long -> float -> double

            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            //Explicit(manually) Convert a larger type to a smaller size type
            //double -> float -> long -> int -> char

            double myOtherDouble = 9.78;
            int myOtherInt = (int)myOtherDouble; //Manual casting: double to int

            Console.WriteLine(myOtherDouble);
            Console.WriteLine(myOtherInt);

            /*Type conversion methods
             It is possible to convert data types explicitly using built-in methods*/

            int myAnotherInt = 10;
            double myAnotherDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myAnotherInt));    //convert int to string
            Console.WriteLine(Convert.ToDouble(myAnotherInt));    //convert int to double
            Console.WriteLine(Convert.ToInt32(myAnotherDouble));  //convert double to int
            Console.WriteLine(Convert.ToString(myBool));          //convert bool to string
        }
    }
}
