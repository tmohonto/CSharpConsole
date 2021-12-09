using System;

namespace MothodOverriding
{
    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("This is a method of parent class");
        }
    }
    class child : parent
    {
        public override void print()
        {
            Console.WriteLine("This is a method of child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent p = new child();
            p.print();
        }
    }
}
