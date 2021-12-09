using System;

namespace MarksheetApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your roll");
            string roll = Console.ReadLine();
            Console.WriteLine("Enter your class");
            string standard = Console.ReadLine();
            Console.WriteLine("Enter bangla marks");
            int bangla = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter math marks");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter physics marks");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter chemistry marks");
            int chemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter english marks");
            int english = int.Parse(Console.ReadLine());

            int obtain = bangla + math + physics + chemistry + english;
            int percent = (obtain * 100) / 500;

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your roll is {0}", roll);
            Console.WriteLine("Your class is {0}", standard);
            Console.WriteLine("Your obtained mmarks are: {0}",obtain);
            Console.WriteLine("Your percent is {0}", percent);

            //if else if for grade

            if(percent >= 80)
            {
                Console.WriteLine("Grade: A-1");
            }
            else if(percent >= 70)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percent >= 60)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percent >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percent >= 40)
            {
                Console.WriteLine("Grade: D");
            }
            else if (percent >= 33)
            {
                Console.WriteLine("Grade: E");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            //if else if for remarks

            if (percent >= 80)
            {
                Console.WriteLine("Remarks: Excellent");
            }
            else if (percent >= 70)
            {
                Console.WriteLine("Remaarks: Very Good");
            }
            else if (percent >= 60)
            {
                Console.WriteLine("Remarks: Good");
            }
            else if (percent >= 50)
            {
                Console.WriteLine("Remarks: Fair");
            }
            else if (percent >= 40)
            {
                Console.WriteLine("Remarks: Poor");
            }
            else if (percent >= 33)
            {
                Console.WriteLine("Remarks: Needs lot of imporvement");
            }
            else
            {
                Console.WriteLine("Remarks: Bring your parents tomoorrow");
            }

            int supply = 0;

            if(bangla <33)
            {
                supply++;
                Console.WriteLine("You have supply in Bangla subject");
            }
            if (math < 33)
            {
                supply++;
                Console.WriteLine("You have supply in Math subject");
            }
            if (english < 33)
            {
                supply++;
                Console.WriteLine("You have supply in English subject");
            }
            if (physics < 33)
            {
                supply++;
                Console.WriteLine("You have supply in Physics subject");
            }
            if (chemistry < 33)
            {
                supply++;
                Console.WriteLine("You have supply in Chemistry subject");
            }

            Console.WriteLine("You are failed in {0} subjects", supply);
        }
    }
}
