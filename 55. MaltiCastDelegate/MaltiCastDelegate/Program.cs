using System;

namespace MaltiCastDelegate
{
    public delegate void calculation(int num1, int num2);
    class Program
    {
        public static void add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Add result is: {0}", result);
        }
        public static void sub(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Sub result is: {0}", result);
        }
        public static void multiple(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Multiple result is: {0}", result);
        }
        public static void div(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("div result is: {0}", result);
        }
        static void Main(string[] args)
        {
            calculation obj = new calculation(add);
            obj += sub;
            obj += multiple;
            obj -= div;
            obj(100, 100);
        }
    }
}
