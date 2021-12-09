using System;

namespace Interfaces
{
    interface Iemployee
    {
        void show();
    }
    class partTimeEmployees : Iemployee
    {
        public void show()
        {
            Console.WriteLine("Childs");
        }
    }
    class Program
    {
       static void Main(string[] args) 
       {
            partTimeEmployees obj = new partTimeEmployees();
            obj.show();
       }
    }
}
