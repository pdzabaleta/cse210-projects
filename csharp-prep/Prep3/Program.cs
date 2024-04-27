using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.WriteLine("This is a C# document. ENJOY IT! :) ");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.WriteLine("Guess the magic number!");
        

        

        int numberGuessed = -1;
        
       do{
        Console.Write("What is your guess?: ");
        string gessNumber = Console.ReadLine();
        numberGuessed = int.Parse(gessNumber);
       
        if (number > numberGuessed){
            Console.WriteLine("Higher");
        }

        else if (number == numberGuessed) {
            Console.WriteLine("You guessed it!");
        }

        else{
            Console.WriteLine("Lower");
        }
       }while (number != numberGuessed);
    }
}