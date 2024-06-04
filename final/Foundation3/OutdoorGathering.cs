using System;
public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public override string EventType()
    {
        return "Outdoor Gathering"; 
    }
    public override string GetDetails()
    {
        return $"Weather: {_weather}";
    }
}