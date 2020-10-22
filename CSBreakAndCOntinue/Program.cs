using System;

namespace CSBreakAndCOntinue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*C# Break*/
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            /*C# Continue*/
            //Breaks one interation and continues with the next iteration in the loop
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
