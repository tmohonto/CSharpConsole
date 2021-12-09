using System;

namespace PassValuePassRefference
{
    class Program
    {
        //public static void PassValue(int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine("Value is: {0}",a);  
        //}
        //public static void PassReference(ref int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine("Value is: {0}",a);  
        //}
        public static void PassOut(out int a)
        {
            a = 10;
            Console.WriteLine("Value is: {0}", a);
        }
        static void Main(string[] args)
        {
            //int a = 5;
            //PassValue(a);
            //PassReference(ref a);
            //Console.WriteLine(a);
            int a;
            PassOut(out a);
            Console.WriteLine(a);
        }
    }
}
