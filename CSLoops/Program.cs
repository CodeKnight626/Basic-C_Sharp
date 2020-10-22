using System;

namespace CSLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop
            /*
            int i = 0;
            while(i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);*/

            /*For Loop*/

            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
