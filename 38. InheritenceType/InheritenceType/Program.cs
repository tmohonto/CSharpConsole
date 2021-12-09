using System;

namespace InheritenceType
{
    class baseClass
    {
        public void show()
        {
            Console.WriteLine("This is a parents class");
        }
    }
    class deriverClass1 : baseClass
    {
        public void show2()
        {
            Console.WriteLine("This is child class 1");
        }
    }
    class derivedClass2 : baseClass
    {
        public void show3()
        {
            Console.WriteLine("This is child class 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            deriverClass1 mohonto = new deriverClass1();
            mohonto.show();
        }
    }
}
