using System;

namespace SingleMultiDimension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] age = new int[3, 4]
            {
                {10,11,12,13 },
                { 14,15,16,17},
                { 18,19,20,21}
            };
            for (int i = 0; i < age.GetLength(0); i++)
            {
                for (int j = 0; j < age.GetLength(1); j++)
                {
                    Console.Write(age[i, j] + "\n ");
                }
                //Console.WriteLine();
            }

            //int[] salary = new int[3];
            //salary[0] = 15000;
            //salary[1] = 20000;
            //salary[2] = 30000;
            //for (int i = 0; i < salary.Length; i++)
            //{
            //    Console.WriteLine(salary[i]);
            //}
        }
    }
}
