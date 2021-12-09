using System;

namespace Decision_if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (name == "Tonmoy" && password=="tonmoy007")
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect username or password"); ;
            }
            //int x = 5;
            //if(x>10)
            //{
            //    Console.WriteLine("X is greater");
            //}
            //else
            //{
            //    Console.WriteLine("X is less");
            //}
            
        }
    }
}
