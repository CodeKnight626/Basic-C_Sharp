using System;

namespace AccesModifiersCS
{
    class Car
    {
        // Public field accesible from all classes
        public string model = "Mustang";

        // Private field accesible in this class only
        //private string model = "Mustang";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
}
