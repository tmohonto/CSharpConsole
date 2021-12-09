using System;

namespace Indexers
{
    class employee
    {
        private int[] Age = new int[10];
        public int this[int index]
        {
            set 
            { 
                if(index>=0 && index < Age.Length)
                {
                    if (value > 0) 
                    { 
                        Age[index] = value; 
                    } 
                    else
                    {
                        Console.WriteLine("Value is invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            get 
            { 
                return Age[index]; 
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp[8] = 10;
            Console.WriteLine(emp[8]);
        }
    }
}
