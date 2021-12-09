using System;

namespace DifferenceBetweenWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("............");
            Console.WriteLine(i);
            Console.WriteLine("............");
            Console.WriteLine(i);

            int j = 0;

            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine(".........");
            Console.WriteLine(j);
        }
    }
}
