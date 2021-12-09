using System;

namespace Delegate
{
    public delegate void Calculation(int a, int b);
    class Program
    {
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Add is: {0}", result);
        }
        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Sub is: {0}", result);
        }
        public static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiply is: {0}", result);
        }
        public static void Div(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Div is: {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Add);
            obj(30, 45);
            Calculation obj2 = new Calculation(Program.Sub);
            obj2(30, 45);
            Calculation obj3 = new Calculation(Program.Multiply);
            obj3(30, 45);
            Calculation obj4 = new Calculation(Program.Div);
            obj4(30, 45);
        }
    }
}
