using System;

namespace MethodsCS
{
    class Program
    {
        /*CS Methods*/

        /*
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        static void Main(string[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
        }
        // I just got executed!
        // I just got executed!
        // I just got executed!
        
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");
        }
        // Sweden
        // India
        // Norway
        // USA
        

        /*Multiple parameters*/
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        /*Return values
        static int MyOtherMethod(int x)
        {
            return 5 + x;
        }

        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
            Console.WriteLine(MyOtherMethod(3));
        }
        


        //Named arguments

        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The Youngest child is: " + child3);
        }
        static void Main(string[] args)
        {
            MyMethod(child3: "John", child1: "Liam", child2: "Liam");
        }
        */


        //Method Overloading
        /*With method overloading, multiple methods can have the same name with different parameters:*/
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main()
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);

            Console.WriteLine(myNum1);
            Console.WriteLine(myNum2);
        }
    }
}
