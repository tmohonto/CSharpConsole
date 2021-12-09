using System;

namespace NestedSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your pizza flavour: ");
            string pizza = Console.ReadLine();

            switch(pizza)
            {
                case "Fatija":
                    Console.WriteLine("you have selected fajita pizza");
                    break;
                case "supreme":
                    Console.WriteLine("You have selected supreme pizza");
                    break;
                case "cheese":
                    Console.WriteLine("You have selected cheese pizza");
                    break;
                case "vegetable":
                    Console.WriteLine("Enter your vegetables: ");
                    string vegetable = Console.ReadLine();
                    switch(vegetable)
                    {

                    }
                    break;
                default:
                    Console.WriteLine("Pizza flavour not available");
                    break;
            }
        }
    }
}
