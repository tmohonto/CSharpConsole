using System;

namespace AccessSpecifiers2
{
    public class class1
    {
        //protected void show1()  protected method use in as a child class
        //{
        //    Console.WriteLine("This is a protected method");
        //}

        internal void show1()
        {
            Console.WriteLine("This is a internal method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.show1();
        }
    }
}
