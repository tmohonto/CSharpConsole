using System;

namespace ExplicitInterface
{
    interface i1
    {
        void show();
    }
    interface i2
    {
        void show();
    }
    class MyClass : i1, i2
    {
        //This is implicit 
        public void show()
        {
            Console.WriteLine("This is a method of i1");
        }
        //void i1.show()
        //{
        //    Console.WriteLine("This is a method of i1 interface");
        //}
        void i2.show()
        {
            Console.WriteLine("This is a method of i2 interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass obj = new MyClass();
            //((i1)obj).show();
            //((i2)obj).show();
            MyClass obj = new MyClass();
            obj.show();
            i1 obj1 = new MyClass();
            obj1.show();
            i2 obj2 = new MyClass();
            obj2.show();
        }
    }
}
