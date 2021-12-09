using System;

namespace Destructor
{
    class person
    {
        public string name;
        public int age;
        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        ~person()
        {
            Console.WriteLine("Destructor has been run");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person tonmoy = new person("tonmoy", 23);
            Console.WriteLine(tonmoy.getName());
            Console.WriteLine(tonmoy.getAge());
        }
    }
}
