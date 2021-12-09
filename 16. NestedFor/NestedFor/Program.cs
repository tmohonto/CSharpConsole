using System;

namespace NestedFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1;  i<= 3; i++)
            {
                Console.WriteLine("Tonmoy");
                for (int j = 1; j < 2; j++)
                {
                    Console.WriteLine("Kumer");
                    for (int k = 1; k < 2; k++)
                    {
                        Console.WriteLine("Mohonto");
                    }
                }
            }
            Console.WriteLine("Loop Tarminatead");
        }
    }
}
