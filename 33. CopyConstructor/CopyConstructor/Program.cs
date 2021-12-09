using System;

namespace CopyConstructor
{
    class Examples
    {
        string name;
        int age;

        public Examples(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Examples(Examples x)
        {
            this.name = x.name;
            this.age = x.age;
        }

        public void getData()
        {
            Console.WriteLine("Name is: {0}", name);
            Console.WriteLine("Age is: {0}", age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Examples x1 = new Examples("x", 7);
            x1.getData();
            Examples x2 = new Examples(x1);
            x2.getData();
        }
    }
}
