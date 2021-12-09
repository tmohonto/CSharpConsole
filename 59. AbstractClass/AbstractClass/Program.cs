using System;

namespace AbstractClass
{
    abstract class person
    {
        public string firstname;
        public string finalname;
        public int age;
        public string phoneNumber;
        public abstract void printDetails();
    }
    class student : person
    {
        public int rollNo;
        public int fees;

        public override void printDetails()
        {
            string name = this.firstname + " " + this.finalname;
            Console.WriteLine("Student name is: {0}", name);
            Console.WriteLine("Student age is: {0}", this.age);
            Console.WriteLine("Student phone number is: {0}", this.phoneNumber);
            Console.WriteLine("Student roll no is: {0}", this.rollNo);
        }
    }
    class teacher : person
    {
        public string qualification;
        public int salary;
        public override void printDetails()
        {
            string name = this.firstname + " " + this.finalname;
            Console.WriteLine("Teacher name is: {0}", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student tonmoy = new student();
            tonmoy.firstname = "tonmoy";
            tonmoy.finalname = "kumer";
            tonmoy.age = 23;
            tonmoy.phoneNumber = "01796622510";
            tonmoy.rollNo = 7;
            tonmoy.fees = 1000;
            tonmoy.printDetails();
            
            teacher apon = new teacher();
            apon.firstname = "apon";
            apon.finalname = "mohonto";
            apon.printDetails();
        }
    }
}
