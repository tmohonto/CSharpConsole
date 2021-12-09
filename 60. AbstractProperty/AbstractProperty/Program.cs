using System;

namespace AbstractProperty
{
    abstract class person
    {
        public abstract int id { get; set; }
        public abstract string name { get; set; }
    }
    class student : person
    {
        int studentId;
        string studentName;
        public override int id 
        {
            set
            {
                this.studentId = value;
            }
            get
            {
                return this.studentId;
            }
        }
        public override string name 
        {
            set
            {
                this.studentName = value;
            }
            get
            {
                return this.studentName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student mohonto = new student();
            mohonto.id = 7;
            mohonto.name = "mohonto";
            Console.WriteLine(mohonto.id);
            Console.WriteLine(mohonto.name);
        }
    }
}
