using System;

namespace VarAndDynamickeywords
{
    class Program
    {
        public static dynamic show(dynamic name)
        {
            return name;
        }
        static void Main(string[] args)
        {
            //var name = "Tonmoy";
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.GetType());

            dynamic name = "Tonmoy";
            //Console.WriteLine(name);
            Program.show(name);
        }
    }
}
