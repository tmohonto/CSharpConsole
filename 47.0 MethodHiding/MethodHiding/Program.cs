using System;

namespace MethodHiding
{
    class parent
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }
    class child : parent
    {
        public new void show()
        {
            //base.show();
            Console.WriteLine("Child class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            //((parent)c).show();
            c.show();
        }
    }
}
