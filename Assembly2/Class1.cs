using System;


namespace Assembly2
{ 
     class Student
{
    internal string name = "Samiksha";
}
class Program
{
    static void Main(string[] args)
    {
        Student theStudent = new Student();
        Console.WriteLine("Name: " + theStudent.name);
        Console.ReadLine();
    }
}
}