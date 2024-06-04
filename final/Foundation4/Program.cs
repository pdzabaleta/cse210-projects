using System;

class Program
{
    static void Main(string[] args)
    {
        Running runningActivity = new Running("03 Nov 2022", 30, 4.8f);
        Console.WriteLine(runningActivity.GetSummary());
        Cycling cyclingActivity = new Cycling("12 Dec 2023", 60, 15.0f); 
        Console.WriteLine(cyclingActivity.GetSummary());
        Swimming swimmingActivity = new Swimming("28 Feb 2022", 20, 100);
        Console.WriteLine(swimmingActivity.GetSummary());
    }
}