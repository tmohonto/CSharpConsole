using System;

namespace Anonymous
{
    public delegate void myDelegate(int num);
    class Program
    {
        //public static void myMethod(int a)
        //{
        //    a += 10;
        //    Console.WriteLine(a);
        //} // delegate

        public static void myMethod(myDelegate del, int a)
        {
            a += 10;
            del(a);
        }
        static void Main(string[] args)
        {
            //myDelegate obj = new myDelegate(Program.myMethod);
            //obj(7); // delegate

            //myDelegate obj = delegate (int a)
            //{
            //    a += 10;
            //    Console.WriteLine(a);
            //};
            //obj(8); // annonymous method

            Program.myMethod(delegate (int b)
            {
                b += 10;
                Console.WriteLine(b);
            }, 10); //annonymous as a variable
        }
    }
}
