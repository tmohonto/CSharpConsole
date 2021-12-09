using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] number = new int[4];
            //number[0] = 10;
            //number[1] = 20;
            //number[2] = 30;
            //number[3] = 40;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            string[] names = new string[4];
            names[0] = "Tonmoy";
            names[1] = "Kumer";
            names[2] = "Mohonto";
            names[3] = "Debasis";

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
