using System;

namespace Inheritence
{
    class visitingEmployees : Employees
    {
        public int visitingEmployeesSalary;
        public int visitingEmployeesHours;
    }
    class permanentEmployees : Employees
    {
        public int permanentEmployeesSalary;
        public int permanentEmployeesHours;
    }
    class Employees
    {
        public string names;
        public void show()
        {
            Console.WriteLine("This is a method of parents class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            permanentEmployees tonmoy = new permanentEmployees();
            tonmoy.names = "tonmoy";
            Console.WriteLine(tonmoy.names);
            visitingEmployees apon = new visitingEmployees();
            apon.names = "apon";
            Console.WriteLine(apon.names);
        }
    }
}
