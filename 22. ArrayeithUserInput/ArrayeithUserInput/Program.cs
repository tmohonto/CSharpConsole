using System;

namespace ArrayeithUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number of items u want to store in an array?");
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter Data on location"+ (i+1));
                int data = int.Parse(Console.ReadLine());
                numbers[i] = data;
            }
            Console.WriteLine("Your Data");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
