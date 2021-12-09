using System;

namespace SealedClass
{
    class parentClass
    {
        public void show()
        {
            Console.WriteLine("This is parent class");
        }
    }
    sealed class childClass : parentClass // sealed class can not parent class
    {
        public void show1()
        {
            Console.WriteLine("This is a child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            childClass child = new childClass();
            child.show();
        }
    }
}
