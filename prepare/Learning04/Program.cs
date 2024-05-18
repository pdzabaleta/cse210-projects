using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment name1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(name1.GetSumary());

        MathAssignment name2 = new MathAssignment("Sam Pockett", "Addition", "7.2", "3-9" );
        Console.WriteLine(name2.GetSumary());
        Console.WriteLine(name2.GetHomeworkList());

        WritingAssignment name3 = new WritingAssignment("Cat Valentine", "Psychology",  "Stand Up");
        Console.WriteLine(name3.GetSumary());
        Console.WriteLine(name3.GetWritingInformation());
    }
}