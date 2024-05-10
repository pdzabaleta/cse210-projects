using System;

class Program
{
    static void Main(string[] args)
    {
        

        Fraction f1 = new Fraction();   
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3,4);
        

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        /////////////////////////////////////
        Console.WriteLine("Type a top");
        string e = Console.ReadLine();
        int a = int.Parse(e);

        Console.WriteLine("Type a bottom");
        string i = Console.ReadLine();
        int b = int.Parse(i);
        Fraction f4 = new Fraction(a,b);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}