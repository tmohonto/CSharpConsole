using System;

namespace MultipleInheritence
{
    class person
    {
        //public void show1()
        //{
        //    Console.WriteLine("This is a methos of person class");
        //}
        public void show()
        {
            Console.WriteLine("This is a methos of person class");
        }
    }
    interface Employee
    {
        //void show2();
        void show();
    }
    interface Employee1
    {
        void show();
    }
    class teacher : person, Employee, Employee1
    {
        //public void show2()
        //{
        //    Console.WriteLine("This is a method of employee interface");
        //}
        void Employee.show()
        {
            Console.WriteLine("This is a method of employee interface");
        }
        void Employee1.show()
        {
            Console.WriteLine("This is a method of employee 1 interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            teacher t = new teacher();
            //t.show1();
            //t.show2();
            t.show();
            Employee e = new teacher();
            e.show();
        }
    }
}
