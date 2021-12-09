using System;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "50";
            string num2 = "50";
            int num3 = int.Parse(num1) + int.Parse(num2);
            Console.WriteLine(num3);
            //float num1 = 20.234f;
            //int num2 = Convert.ToInt32(num1);
            //int b = (int)a; // explicit data type conversion
            //Console.WriteLine(num2);
            //int a = 20;
            float a = 15.50f;
            int b = Convert.ToInt32(a); // implicit data type conversion
            Console.WriteLine(b);
        }
    }
}
