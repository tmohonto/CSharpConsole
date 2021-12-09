using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int num1 = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num1 + "X" + i + "=" + num1 * i);
            }

            //Console.WriteLine("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}

