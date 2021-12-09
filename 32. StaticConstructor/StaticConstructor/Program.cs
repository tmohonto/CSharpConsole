using System;

namespace StaticConstructor
{
    class person
    {
        public static string personName;
        public static string personAge;

        static person()
        {
            personName = "Tonmoy";
            personAge = "23";
            Console.WriteLine("Static constructor runs");
        }

        public person()
        {
            Console.WriteLine("Default constructor");
        }
        public static void getDetails()
        {
            Console.WriteLine("Person name is {0}", personName);
            Console.WriteLine("Person age is {0}", personAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person tonmoy = new person();
            person.getDetails();
            person apon = new person();
        }
    }
}
