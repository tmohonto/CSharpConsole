using System;

namespace AccessSpecifiers1
{
    public class class1
    {
        public void show1()
        {
            Console.WriteLine("This is a pubic method");
        }
        //public void show2()
        //{
        //    class1 c1 = new class1();
        //    c1.show1();
        //}
    }
    class Program1 : class1
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.show1();
        }
    }
}
