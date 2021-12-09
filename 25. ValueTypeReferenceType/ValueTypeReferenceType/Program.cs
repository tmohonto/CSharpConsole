using System;

namespace ValueTypeReferenceType
{ 
    struct Employee
    {
        public int Salary;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Salary = 15000;
            e.Age = 20;

            Employee e1 = e;
            Employee e2 = e;

            e.Age = 26;
            Console.WriteLine(e.Age);
            Console.WriteLine(e1.Age);
            Console.WriteLine(e2.Age);
        }
    }
}
