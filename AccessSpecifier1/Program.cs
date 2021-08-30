using System;

namespace AccessSpecifier1
{


    class Student
    {
        public string name = "Samiksha";

        public void print()
        {
            Console.WriteLine(" Student class");
        }
    }
    class Student2
    {
        protected string name = "Samu";
    }


    class Program : Student2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student student1 = new Student();
            Console.WriteLine("Name: " + student1.name);
            student1.print();
            Console.ReadLine();

            Program program = new Program();
            Console.WriteLine("Name: " + program.name);
            Console.ReadLine();

        }

    }
}