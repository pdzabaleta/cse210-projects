using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _responses = new List<string>();
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "\nOur Listing Activity program empowers users to organize and manage information efficiently, providing tools for creating, editing, and categorizing lists tailored to individual needs.";

        _prompts.Add("How has your faith influenced your decisions this week?");
        _prompts.Add("In what ways have you seen God's hand in your life recently?");
        _prompts.Add("What scriptures have brought you comfort or guidance lately?");
        _prompts.Add("How have you shared your beliefs with others recently?");
        _prompts.Add("What blessings are you grateful for today?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        DisplayPrompt();
        Console.Write("You may begin in: \n");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        do
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses.Add(response); // Almacena la respuesta ingresada// Stores the entered response

            // repetir bucle hasta que se acabe el tiempo // Repeat loop until the time duration is over
        } while (DateTime.Now < stopTime);

        Console.WriteLine($"You listed {_responses.Count} items!\n");

        // Ask user if they want to see the entered responses
        Console.Write("Would you like to see the entered responses? (yes/no): ");
        string responseToShow = Console.ReadLine();

        if (responseToShow.ToLower() == "yes")
        {
            // Display the entered responses
            Console.WriteLine("Entered responses:");
            foreach (var response in _responses)
            {
                Console.WriteLine(response);
            }
        }

        Console.WriteLine($"You have completed in {_duration} seconds of this activity!\n");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"----- {GetRandomPrompt()} -----\n");
    }
}
