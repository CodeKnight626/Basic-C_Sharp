using System;
using System.IO; // include the System.IO namespace

namespace FilesCS
{
    class Program
    {
        /*C# Files*/
        static void Main(string[] args)
        {
            string writeText = "Hello World";  //Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of the writetext to it

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
        }
    }
}
