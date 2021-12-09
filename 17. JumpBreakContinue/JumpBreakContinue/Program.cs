using System;

namespace JumpBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)    
            //{
            //    if(i==5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    goto stop;
                }
                Console.WriteLine(i);
            }
        stop:
            Console.WriteLine("Program Exits");
        }
    }
}
