using System;

namespace RestartProgramWithUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("First Number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Second Number:");
                int num2 = int.Parse(Console.ReadLine());
                int num3 = num1 + num2;
                Console.WriteLine("Addition result is: {0}", num3);
                Console.WriteLine("Do you want to repeat math? yes/no");
                string again = Console.ReadLine().ToLower();
                if (again == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            //string again;
            //do
            //{
            //    Console.WriteLine("First Number:");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Second Number:");
            //    int num2 = int.Parse(Console.ReadLine());
            //    int num3 = num1 + num2;
            //    Console.WriteLine("Addition result is: {0}", num3);
            //    Console.WriteLine("Do you want to repeat math? yes/no");
            //    again = Console.ReadLine().ToLower();
            //}
            //while (again == "yes");
        }
    }
}
