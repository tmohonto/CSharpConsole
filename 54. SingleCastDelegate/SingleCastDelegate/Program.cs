using System;

namespace SingleCastDelegate
{
    public delegate void calcutation(int num1, int num2);
    class Program
    {
        public static void Addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Add result is: {0}", result);
        }
        static void Main(string[] args)
        {
            calcutation obj = new calcutation(Addition);
            obj(50, 50);
        }
    }
}
