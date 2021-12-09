using System;

namespace ConstructorOverloading
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Tonmoy is better than the best");
        }
        public Program(int a, int b)
        {
            Console.WriteLine("I can add two number and its {0}",(a+b));
        }
        public Program(string name, int age)
        {
            Console.WriteLine("I can tell your name, your name is {0} and age {1}", name, age);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p3 = new Program("Tonmoy", 23);
        }
    }
}
