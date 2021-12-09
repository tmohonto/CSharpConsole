using System;

namespace SingleMultiCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            //jagged array

            int[][] my_array1 = new int[3][];
            my_array1[0] = new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            my_array1[1] = new[] { 21, 22, 23, 24, 25, 26, 27};
            my_array1[2] = new[] { 31, 32, 33, 34, 35, 36 };

            foreach (int[] item in my_array1)
            {
                foreach (int i in item)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            //for(int i = 0; i < my_array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < my_array1[i].Length; j++)
            //    {
            //        Console.Write(my_array1[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
