using System;

namespace Polymorphism
{
    /* C# Polymorphism and Overriding methods*/
    class Animal // Base Class
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal make a sound");
        }
    }

    class Pig : Animal  // Derived class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create an Animal object
            Animal myPig = new Pig();        // Create a Pig object
            Animal myDog = new Dog();        // Create a Dog object


            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
