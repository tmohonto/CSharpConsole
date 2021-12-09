using System;

namespace TernaryOrconditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 10;
            //string sentence = (num1 < 20) ? "a is greater" : "a is lesser";
            //Console.WriteLine(sentence);

            int a = int.Parse(Console.ReadLine());
            string sentence = (a >= 10) ? "true" : "false";
            Console.WriteLine(sentence);
        }
    }
}
