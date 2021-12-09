using System;

namespace Constructors
{
    class Employees
    {
        //public Employees() // Default Constructor
        //{
        //    Console.WriteLine("Constructor invokes");
        //}
        int EmpId;
        String EmpName;
        int EmpAge;
        public Employees(int EmpId, string EmpName, int EmpAge)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }
        public int getId()
        {
            return this.EmpId;
        }
        public string getName()
        {
            return this.EmpName;
        }
        public int getAge()
        {
            return this.EmpAge;
        }
        static void Main(string[] args)
        {
            //Employees p = new Employees(); // Default Constructor

            Employees Tonmoy = new Employees(7, "Tonmoy", 23);
            Employees Mohonto = new Employees(7, "Mohonto", 23);

            Console.WriteLine("Employee id is: {0}",Tonmoy);
        }
    }
}
