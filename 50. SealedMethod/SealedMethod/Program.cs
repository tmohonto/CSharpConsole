using System;

namespace SealedMethod
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("This is A");
        }
    }
    class B : A
    {
        public override void show()
        {
            Console.WriteLine("This is B");
        }
    }
    class C
    {
        public void print()
        {
            Console.WriteLine("This is print method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            C obj = new C();
            obj.print();
        }
    }
}
