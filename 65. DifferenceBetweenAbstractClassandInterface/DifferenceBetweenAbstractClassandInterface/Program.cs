using System;

namespace DifferenceBetweenAbstractClassandInterface
{
    class Examples
    {

    }
    interface i1
    {

    }
    interface i2
    {

    }
    interface myInterface : i1, i2
    {
        void prints();
    }
    abstract class myClass : Examples, i1, i2
    {
        public myClass()
        {
            Console.WriteLine("Abstract class constructor");
        }
        public abstract void show();
        ~myClass()
        {
            Console.WriteLine("Abstract class destructor");
        }
    }
    class myClass1 : myClass, myInterface
    {
        public override void show()
        {
            Console.WriteLine("This is a method of abstract class.");
        }
        public void prints()
        {
            Console.WriteLine("This is a method of interace");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass1 obj = new myClass1();
        }
    }
}
