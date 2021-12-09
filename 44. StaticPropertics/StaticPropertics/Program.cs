using System;

namespace StaticPropertics
{
    class university
    {
        private static string UniversityName;
        private static string DepartmentName;

        public static string _UniversityName 
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You cannot enter null or empty value in university name");
                }
                else
                {
                    UniversityName = value;
                }
            }
            get
            {
                return UniversityName;
            }
        }
        public static string _DepartmentName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You cannot enter null or empty value in university name");
                }
                else
                {
                    DepartmentName = value;
                }
            }
            get
            {
                return DepartmentName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            university._UniversityName = "Daffodil Internatioal University";
            university._DepartmentName = "Software engineer";
            Console.WriteLine("My university name is {0}",university._UniversityName);
            Console.WriteLine("My department name is {0}", university._DepartmentName);
        }
    }
}
