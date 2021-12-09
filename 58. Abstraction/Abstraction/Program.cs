using System;

namespace Abstraction
{
    class employee
    {
        public int empId;
        public string empName;
        public double grossPay;
        double taxDeduction = 0.1;
        double netSalary;

        public employee(int empId, string eName, double eGrosspay)
        {
            this.empId = empId;
            this.empName = eName;
            this.grossPay = eGrosspay;
        }

        void calculateSalary()
        {
            if(grossPay >= 50000)
            {
                netSalary = grossPay - (taxDeduction * grossPay);
                Console.WriteLine("Your Salary: {0}", netSalary);
            }
            else
            {
                Console.WriteLine("Your salary: {0}",grossPay);
            }
        }
        public void showEmployeeDetails()
        {
            Console.WriteLine("Id is: {0}", empId);
            Console.WriteLine("Name is: {0}", empName);
            this.calculateSalary();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee tonmoy = new employee(007,"tonmoy",50000);
            tonmoy.showEmployeeDetails();
        }
    }
}
