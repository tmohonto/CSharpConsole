using System;

namespace ReadingAndWritingInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("enter your first name");
            //string firstname = console.readline();
            //console.writeline("enter your last name");
            //string lastname = console.readline();
            //console.writeline("your name is " + name + " "); // concatanation syntax
            //console.writeline("your name is {0} {1}", firstname, lastname); // placeholder syntax

            Console.WriteLine("Enter number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Addition : {0}", sum);
        }
    }
}
