using System;

namespace IfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your percent: ");
            int percentage = int.Parse(Console.ReadLine());

            if (percentage >= 80)
            {
                Console.WriteLine("Grade: A-1");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Grade: D");
            }
            else if (percentage >= 33)
            {
                Console.WriteLine("Grade: E");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}
