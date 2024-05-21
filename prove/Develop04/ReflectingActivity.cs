using System;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "\nEngage in a journey of introspection with our Reflecting Activity program, offering a structured approach to deepen self-awareness and promote personal growth.";

        _prompts.Add("Reflect on a recent challenge you faced and how you overcame it.");
        _prompts.Add("Consider a moment when you felt truly inspired. What led to that feeling?");
        _prompts.Add("Think about a mistake you made and what you learned from it.");
        _prompts.Add("Contemplate a time when you stepped out of your comfort zone. What did you discover about yourself?");
        _prompts.Add("Ponder on a meaningful relationship in your life and what it teaches you about connection.");

        // Agregar las preguntas
        _questions.Add("How did the challenge you reflected on shape your perspective or behavior?");
        _questions.Add("What values or beliefs were reaffirmed during the moment of inspiration?");
        _questions.Add("In what ways did the mistake contribute to your personal growth or development?");
        _questions.Add("How did venturing beyond your comfort zone impact your self-confidence or self-awareness?");
        _questions.Add("What insights did you gain about communication, empathy, or trust from the meaningful relationship you considered?");
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following promt:\n");
        DisplayPrompt();
        Console.Write("When you have something in mind press enter to continue:");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the  following questions as they related on this experience\n");
        Console.Write("You may begin in: \n");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        do{
            Console.WriteLine();
            DisplayQuestion();
            ShowSpiner(10);
            Console.WriteLine();
            DisplayQuestion();
            ShowSpiner(10);
            Console.WriteLine();

            // repeat loop for the duration
        }while(DateTime.Now < stopTime);
        


        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"----- {GetRandomPrompt()} -----\n");
    }
    public void DisplayQuestion()
    {
        Console.WriteLine($"- {GetRandomQuestion()}");
    }


}