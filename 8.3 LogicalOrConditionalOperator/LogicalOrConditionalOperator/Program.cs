using System;

namespace LogicalOrConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 40;
            int num2 = 60;

            //bool num3 = (num1 > num2) && (num1 < num2);
            bool num3 = (num1 > num2) || (num1 < num2);
            Console.WriteLine(num3);
        }
    }
}
