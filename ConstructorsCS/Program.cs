using Microsoft.VisualBasic;
using System;
using System.Drawing;

namespace ConstructorsCS
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        // Creates a class constructor with a parameter
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        }
    }
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }*/
}
