using System;

namespace CSVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*In C#, there are different types of variables, for example:
             int
             double
             char
             string
             bool
            
            Declaring, creating a variable
             type variableName = value;
            */

            //Examples

            string name = "John";
            Console.WriteLine(name);

            int myNum = 15;
            Console.WriteLine(myNum);

            int myOtherNum;
            myOtherNum = 20;
            Console.WriteLine(myOtherNum);

            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;

            //Declare many variables
            int x = 5, y = 6, z = 50;

            //Booleans
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            //Floats
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            /*Constants
             You can add the const keyword if you don't want to overwrite existing values
             */

            //Example

            const int myAnotherNum = 15;
            //myAnotherNum = 20 // error
        }
    }
}
