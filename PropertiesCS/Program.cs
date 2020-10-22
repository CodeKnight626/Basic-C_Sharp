using System;

namespace PropertiesCS
{

    class Person
    {
        private string name; //field

        public string Name   //property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        /*Automatic Property*/
        public string OtherName
        { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            myObj.OtherName = "Beck";
            Console.WriteLine(myObj.Name);
            Console.WriteLine(myObj.OtherName);
        }
    }
}
