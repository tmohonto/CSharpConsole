using System;

namespace Methods
{
    class Program
    {
        public void show()//non-static methods
        {
            Console.WriteLine("Welcome to c# programming");
        }
        public static void show1()//static methods
        {
            Console.WriteLine("Welcome to c# programming");
        }
        public static void Add(int num1, int num2)//static methods
        {
            int result = num1 + num2;
            Console.WriteLine("Addition result is: " + result);
        }
        public static void showName(string name = "Unknown")//static methods
        {
            Console.WriteLine("Your name is: " + name);
        }
        public static void showNameAge(string name, int age)
        {
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);
        }
        public static int Add1(int num1, int num2)//static methods
        {
            int result = num1 + num2;
            return result;
        }
        static void Main(string[] args)
        {
            //Program p1 = new Program();
            //p1.show();
            //Console.WriteLine("Enter your first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Program.Add(num1, num2);//argument

            //Program.showName("Tonmoy");

            //Program.showNameAge(age:23, name:"Tonmoy");//named argument

            //Console.WriteLine(Program.Add1(11,12));

            int a = Program.Add1(20, 30);
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
