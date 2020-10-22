using System;

namespace InterfacesCS
{

    /*C# Interface*/

    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
        //void run(); // Interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    /*Multiple interfaces*/

    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text...");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();

            //Multiple interfaces
            DemoClass myOtherObj = new DemoClass();
            myOtherObj.myMethod();
            myOtherObj.myOtherMethod();
        }
    }
}
