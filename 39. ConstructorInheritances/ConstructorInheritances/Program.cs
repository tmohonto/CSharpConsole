using System;

namespace ConstructorInheritances
{
    class BaseClass
    {
        public BaseClass(string messages)
        {
            Console.WriteLine(messages);
        }
    }
    class ChildClass : BaseClass
    {
        public ChildClass() : base("I am a programmer")
        {
            Console.WriteLine("This is a constructor of child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
        }
    }
}
