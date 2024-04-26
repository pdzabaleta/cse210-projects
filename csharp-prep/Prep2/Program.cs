using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("This is a C# document. ENJOY IT! :) ");

        Console.Write("What's your grade percentage?: ");
        string grade = Console.ReadLine();
        float number = float.Parse(grade);

        string letter = "";

        if (number >= 90) {
            letter = "A";
        }
        else if (number >= 80) {
            letter = "B";
        }
        else if (number >= 70) {
            letter = "C";
        }
        else if (number >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        
        if  (number >= 70){
                Console.WriteLine("You passed the course");
        }
        else {
                Console.WriteLine("You did not pass the course");
        }
        
    }
}