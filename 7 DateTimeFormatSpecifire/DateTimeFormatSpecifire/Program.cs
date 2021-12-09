using System;

namespace DateTimeFormatSpecifire
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Time = DateTime.Now;
            Console.WriteLine("{0:d}", Time);
            Console.WriteLine("{0:f}", Time);
            Console.WriteLine("{0:g}", Time);

            Console.WriteLine("{0:m}", Time);
            Console.WriteLine("{0:T}", Time);
            Console.WriteLine("{0:yy}", Time);
            Console.WriteLine("{0:ddd}", Time);
            Console.WriteLine("{0:HH}", Time);
            Console.WriteLine("{0:MM}", Time);
            Console.WriteLine("{0:MMM}", Time);

            Console.WriteLine("{0:HH:mm:ss tt}", Time);
            Console.WriteLine("{0:dd:MM:yyyy}", Time);
        }
    }
}
