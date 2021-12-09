using System;

namespace ClassesAndObject
{
    class student
    {
        string name;
        int roll;
        int standard;
        int age;
        public void setStudent(string name, int roll, int age, int standard)
        {
            this.name = name;
            this.roll = roll;
            this.age = age;
            this.standard = standard;
        }
        public void getStudent()
        {
            Console.WriteLine("Your name is: {0}", this.name);
            Console.WriteLine("Your roll is: {0}", this.roll);
            Console.WriteLine("Your age is: {0}", this.age);
            Console.WriteLine("Your standard is: {0}", this.standard);
        }
        static void Main(string[] args)
        {
            //student tonmoy = new student();
            //tonmoy.setRoll(1);
            //int roll = tonmoy.getRoll();
            //Console.WriteLine(roll);

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your roll:");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your standard:");
            int standard = int.Parse(Console.ReadLine());

            student student = new student();
            student.setStudent(name, roll, age, standard);
            student.getStudent();
        }
    }
}
