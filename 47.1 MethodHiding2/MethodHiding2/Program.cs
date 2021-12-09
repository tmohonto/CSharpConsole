using System;

namespace MethodHiding2
{
    class employee
    {
        public string firstName;
        public string MiddleName;
        public void printFullName()
        {
            Console.WriteLine(firstName + " " + MiddleName);
        }
    }
    class partTimeEmployee : employee
    {
        public new void printFullName()
        {
            Console.WriteLine(firstName + " " + MiddleName + " " + "pte");
        }
    }
    class fullTimeEmployee : employee
    {
        public new void printFullName()
        {
            Console.WriteLine(firstName + " " + MiddleName + " " + "fte");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            partTimeEmployee pte = new partTimeEmployee();
            pte.firstName = "tonmoy";
            pte.MiddleName = "kumer";
            pte.printFullName();
        }
    }
}
