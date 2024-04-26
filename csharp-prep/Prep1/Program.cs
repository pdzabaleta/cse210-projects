using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("Thisis a C# program, Enjoy it!");
        
        // Ask the user for their name
        string firstname, lastname;
        Console.Write("What is your first name?");
        firstname = Console.ReadLine();
        Console.Write("What is your last name?");
        lastname = Console.ReadLine();
        Console.WriteLine($"Your name is, {lastname}, {firstname} {lastname}");
    }
}