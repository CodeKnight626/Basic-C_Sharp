using System;

namespace Classes
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
    /*
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            myObj2.color = "blue";
            Console.WriteLine(myObj2.color);
        }
    }
    */

    
}
