using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }

    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        return $"{Name}: {Description} - Points: {Points}";
    }
    public virtual string ToFileString()
    {
        return $"{Name}|{Description}|{Points}";
    }
}
