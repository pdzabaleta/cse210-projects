using System;
using System.Formats.Asn1;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>();
    private Random _random = new Random();

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);

        // added from program.cs 
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string Display()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
}