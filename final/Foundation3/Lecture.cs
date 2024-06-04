using System;
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    
    public Lecture(string title, string description, string date, string time, string speaker, int capacity, Address address) : base(title, description, date, time, address)
    {   
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string EventType()
    {
        return "Lecture"; 
    }
    public override string GetDetails()
    {
        return $"Speaker: {_speaker}\nCapacity: {_capacity}";
    }
}