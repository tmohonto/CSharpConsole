using System;

namespace Calculator
{
    class Program
    {
        public static void Addition(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is: {0}",result);
        }
        public static void Subtraction(int a , int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is: {0}",result);
        }
        public static void Multiplication(int a , int b)
        {
            int result = a * b;
            Console.WriteLine("Maltiplication result is: {0}",result);
        }
        public static void Division(int a , int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is: {0}",result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator(+, -, *, /)");
            string Operator = Console.ReadLine();
            if (Operator.Equals("+"))
            {
                Program.Addition(num1, num2);
            }
            else if (Operator.Equals("-"))
            {
                Program.Subtraction(num1, num2);
            }
            else if (Operator.Equals("*"))
            {
                Program.Multiplication(num1, num2);
            }
            else if (Operator.Equals("/"))
            {
                Program.Division(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid operator.......");
            }
        }
    }
}
