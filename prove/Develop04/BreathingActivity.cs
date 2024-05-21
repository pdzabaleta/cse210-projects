using System;
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "\nA C# program that guides users through timed breathing exercises for relaxation and stress reduction.";
    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        do{

            Console.Write("\nBreathe In...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("\nBreathe out...");
            ShowCountDown(5);
            Console.WriteLine();

            // repeat loop for the duration
        }while(DateTime.Now < stopTime);
        

        DisplayEndingMessage();
    }
}