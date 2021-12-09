using System;

namespace Encapsulation
{
    class person
    {
        private string Name;
        private int Age;

        public void setName(string Name)
        {
            if(string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                this.Name = Name;
            }    
        }

        public void getName()
        {
            if(string.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your name is: " + this.Name);
            }
        }

        public void setAge(int Age)
        {
            if(Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("set");
            }
        }

        public void getAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("Your age is:" + this.Age);
            }
            else
            {

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person a = new person();
            a.setName("apon");
            a.getName();
            a.setAge(7);
            a.getAge();
        }
    }
}
