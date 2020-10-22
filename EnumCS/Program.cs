using System;

namespace EnumCS
{
    /*Enum*/
    /*enum Level
    {
        Low,
        Medium,
        High
    }*/
    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }

        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }

        enum OtherMonths
        {
            January,    // 0
            February,   // 1
            March=6,    // 6
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }

        static void Main(string[] args)
        {
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);

            int myOtherNum = (int)OtherMonths.April;
            Console.WriteLine(myOtherNum);

            Level myVar = Level.High;

            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High Level");
                    break;
            }
        }
    }
}
