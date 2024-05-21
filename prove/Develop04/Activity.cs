using System;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    public void DisplayStartingMessage()
    {
        
        Console.WriteLine($"\nWelcome to the {_name}");
        Console.Write("\nHow many seconds you want?:  ");
        string i = Console.ReadLine();
        _duration = int.Parse(i);
        Console.Clear();
        Console.WriteLine("Get Ready ");
        ShowSpiner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!");
        ShowSpiner(5);
        Console.Clear();
    }
    public void ShowSpiner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(seconds);
        
        List<string> animationStrings = new List<string> { "/", "-", "\\", "|" };

        int animationIndex = 0;

        while (DateTime.Now < stopTime)
        {
            Console.Write(animationStrings[animationIndex]);
            Thread.Sleep(250); // ajustar para que el ciclo de animación sea más fluido
            Console.Write("\b \b");

            animationIndex++;
            if (animationIndex >= animationStrings.Count)
            {
                animationIndex = 0;
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    
    }
}
