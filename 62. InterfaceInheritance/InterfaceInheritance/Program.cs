using System;

namespace InterfaceInheritance
{
    interface inter
    {
        void show1();
    }
    interface inter2
    {
        void show2();
    }
    interface inter3 : inter, inter2
    {
        void show3();
    }
    class Program : inter3
    {
        public void show1()
        {
            Console.WriteLine("This is first interface");
        }
        public void show2()
        {
            Console.WriteLine("This is second interface");
        }
        public void show3()
        {
            Console.WriteLine("This is third interface");
        }
        static void Main(string[] args)
        {
            inter a = new Program();
            a.show1();

            //Program a = new Program();
            //a.show1();
            //a.show2();
            //a.show3();
        }
    }
}
