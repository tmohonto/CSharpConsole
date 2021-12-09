using System;

namespace StaticAndInstanceMembers
{
    class student
    {
        public int roll;
        public string firstName;
        public string lastName;
        public int standard;
        public static string schoolName = "ABC";
        public static int fees = 2000;

        public void PrintFullName()
        {
            string Name = this.firstName + " " + this.lastName;
            Console.WriteLine("Name is {0}", Name);
        }

        public static int getFees()
        {
            return fees;
        }

        public static int getFeesAnnualIncrement(int fee)
        {
            return fee / 25;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student tonmoy = new student();
            tonmoy.roll = 1;
            tonmoy.firstName = "Tonmoy";
            tonmoy.lastName = "Mohonto";
            tonmoy.standard = 16;

            student Apon = new student();
            Apon.standard = 1;
            Apon.firstName = "Apon";
            Apon.lastName = "Mohonto";
            Apon.standard = 2;

            Console.WriteLine(tonmoy.roll);
            Console.WriteLine(tonmoy.firstName);
            Console.WriteLine(tonmoy.lastName);
            Console.WriteLine(tonmoy.standard);
            tonmoy.PrintFullName();
            Console.WriteLine(student.schoolName);
            Console.WriteLine(student.getFeesAnnualIncrement(600));
        }
    }
}
