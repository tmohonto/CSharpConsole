using System;

namespace PrivateConstructor
{
    class examples
    {
        public string name;
        public static int a;
        public examples(string name)
        {
            this.name = name;
        }
        private examples()
        {

        }
        public static int getIncrement()
        {
            return ++a;
        }
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            examples x = new examples("Tonmoy");
            examples.getTime();
            examples.a = 20;
            Console.WriteLine(examples.getIncrement());
        }
    }
}
