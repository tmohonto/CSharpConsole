using System;

namespace Properties
{
    class student
    {
        public string FirstName { get; private set; }
        public string Name { get; private set; }
        public student(string firstName, string name)
        {
            FirstName = firstName;
            Name = name;
        }
        //private int _StdId;
        //private string _Name;
        //private string _Firstname;
        //private int _SubjectTotalMark = 100;
        //public int SubjectTotalMark
        //{
        //    get
        //    {
        //        return this._SubjectTotalMark;
        //    }
        //}
        //public int StdId
        //{
        //    set
        //    {
        //        if (value <= 0)
        //        {
        //            Console.WriteLine("Id cannot be zero");
        //        }
        //        else
        //        {
        //            this._StdId = value;
        //        }
        //    }
        //    get
        //    {
        //        return this._StdId;
        //    }
        //}
        //public string Name
        //{
        //    set
        //    {
        //        if(string.IsNullOrEmpty(value))
        //        {
        //            Console.WriteLine("Please enter your name");
        //        }
        //        else
        //        {
        //            this._Name = value;
        //        }
        //    }
        //    get
        //    {
        //        return this._Name;
        //    }
        //}
        //public string FirstName
        //{
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            Console.WriteLine("Please enter your name");
        //        }
        //        else
        //        {
        //            this._Firstname = value;
        //        }
        //    }
        //    get
        //    {
        //        return this._Firstname;
        //    }
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student("tonmoy","kumer");
            Console.WriteLine(s.FirstName);
            Console.WriteLine(s.Name);
            //Console.WriteLine(s.SubjectTotalMark);
            //s.StdId = 23;
            //s.Name = "tonmoy";
            //s.FirstName = "Kumer";
            //Console.WriteLine(s.StdId);
            //Console.WriteLine(s.Name);
            //Console.WriteLine(s.FirstName);
        }
    }
}
