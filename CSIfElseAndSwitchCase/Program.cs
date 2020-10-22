using System;

namespace CSIfElseAndSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*C# If Else*/
            if(20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int x = 20;
            int y = 28;
            
            if(x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            /*int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day");
            }
            else
            {
                Console.WriteLine("Good evening");
            }
            // Outupts "Good evening"*/

            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning. ");
            }
            else if (time  < 20)
            {
                Console.WriteLine("Good day. ");
            }
            else
            {
                Console.WriteLine("Good evening. "); 
            }

            //Short if
            int otherTime = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            /*Switch Case*/

            int day = 8;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Thursday" (day 4)
        }
    }
}
