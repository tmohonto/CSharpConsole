using System;

namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();

            if(email == "codermohonto@outlook.com")
            {
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                if(password == "tonmoy007")
                {
                    Console.WriteLine("Login succcessful"); ;
                }
                else
                {
                    Console.WriteLine("Invalid password"); ;
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            //int a = 8;

            //if(a > 5)
            //{
            //    if(a == 10)
            //    {
            //        Console.WriteLine("A is 10");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A is not 10");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("A is less");
            //}
            Console.WriteLine("");
        }
    }
}
