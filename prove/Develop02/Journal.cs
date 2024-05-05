using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response);
        Entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"Date: {entry.GetFormattedDateTime()}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Prompt}|{entry.Response}|{entry.GetFormattedDateTime()}");
            }
        }
        Console.WriteLine("Entries saved to file successfully.");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            Entries.Clear(); // Limpiar las entradas existentes antes de cargar desde el archivo
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string prompt = parts[0];
                        string response = parts[1];
                        string dateTimeString = parts[2];
                        DateTime dateTime;
                        if (DateTime.TryParse(dateTimeString, out dateTime))
                        {
                            Entries.Add(new Entry(prompt, response) { Date = dateTime });
                        }
                    }
                }
            }
            Console.WriteLine("Entries loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}