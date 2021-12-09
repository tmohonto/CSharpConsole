using System;

namespace MultipleDelegate
{
    public delegate void calculation2(int num);
    public delegate void print();
    class Program
    {
        public static void square(int num)
        {
            int square = num * num;
            Console.WriteLine("Square of {0} is {1}", num, square);
        }
        public static void cube(int num)
        {
            int cube = num * num * num;
            Console.WriteLine("Cube of {0} is {1}", num, cube);
        }
        public static void print()
        {
            Console.WriteLine("The writer of this code is tonmoy");
        }
        static void Main(string[] args)
        {
            calculation2 obj = new calculation2(square);
            obj(3);
            obj = cube;
            obj(5);
            Console.ReadLine();
        }
    }
}
