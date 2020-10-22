using System;

//System.Linq Namespace provides methods such as Min, Max, and Sum
using System.Linq;

namespace ArraysCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*C# Arrays*/
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda"};
            int[] myNum = { 10, 20, 30, 40 };

            //Access array elements
            Console.WriteLine(cars[0]);
            //Outputs Volvo

            //Change array elements
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            //Now outputs Opel

            //Array length
            Console.WriteLine(cars.Length);
            //Outputs 4

            //Loop through an Array
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            //Sort arrays
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            int[] myOtherNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myOtherNumbers.Max()); //returns the large value
            Console.WriteLine(myOtherNumbers.Min()); //return the smallest value
            Console.WriteLine(myOtherNumbers.Sum()); // return the sum of elements

            /*Other forms to create arrays*/

            // Create an array of four elements, and add values later
            //string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            //string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            /*
             // Declare an array
             string[] cars;

             // Add values, using new
             cars = new string[] {"Volvo", "BMW", "Ford"};

             // Add values without using new (this will cause an error)
             cars = {"Volvo", "BMW", "Ford"};
           */
        }
    }
}
