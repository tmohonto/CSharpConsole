using System;

namespace RelationalOrComparisionOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 25;

            //bool TrueOrFalse = num1 == num2;
            //bool TrueOrFalse = num1 != num2;
            //bool TrueOrFalse = num1 < num2;
            bool TrueOrFalse = num1 <= num2;

            Console.WriteLine(TrueOrFalse);
        }
    }
}
