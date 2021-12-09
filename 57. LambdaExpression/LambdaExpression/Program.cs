using System;

namespace LambdaExpression
{
    public delegate int myDelegate(int num);
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate obj = (num) => num * num;
            int num1 = obj(10);
            Console.WriteLine(num1);

            //myDelegate obj = (num) =>
            //{
            //    num += 10;
            //    Console.WriteLine(num);
            //}; // statement lambda expression
            //obj(10);

            //myDelegate obj = delegate (int a)
            //{
            //    a += 5;
            //    Console.WriteLine(a);
            //};
            //obj(5);
        }
    }
}
