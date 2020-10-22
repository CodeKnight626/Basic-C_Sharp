using System;

namespace InheritanceCS
{
    /* C# Inheritance*/

    //To prevent other classes to inherit from a class use the sealed keyword
    sealed class AnotherVehicle
    {

    }

    class Vehicle   // base class (parent)
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle   // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehilce class) and the value of the model name from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
