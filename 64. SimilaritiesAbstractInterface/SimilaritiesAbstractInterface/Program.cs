using System;

namespace SimilaritiesAbstractInterface
{
    interface i1
    {

    }
    interface i2
    {

    }
    interface myInterface : i1, i2
    {
        void print();
    }
    abstract class MyClass : i1, i2
    {
        public abstract void print1();
    }
     class example : MyClass, myInterface
    {
        public void print()
        {
            Console.WriteLine("This is a method interface");
        }
        public override void print1()
        {
            Console.WriteLine("This is a method of abstract class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            example obj = new example();
            obj.print();
            obj.print1();
        }
    }
}
