using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            switch(age)
            {
                case 16:
                case 17:
                    Console.WriteLine("You are not eligiblae for vote");
                    break;
                case 18:
                    Console.WriteLine("Yo are eligible for vote");
                    break;
                default:
                    Console.WriteLine("Enter you age");
                    break;

            }
            //int week_number = 2;

            //switch (week_number)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid week day");
            //        break;
            //}
            //Console.WriteLine("Its a beautiful day");
        }
    }
}
