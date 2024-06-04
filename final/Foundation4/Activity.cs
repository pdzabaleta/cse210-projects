using System;
public abstract class Activity
{
    private string _date;
    private int _duration;
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public string GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public abstract float GetDistance();
    
    public abstract float GetSpeed();
    public abstract float GetPace();
    public abstract string GetActivityType();
    public virtual string GetSummary()
    {
        return $"\n{GetDate()} {GetActivityType()} ({GetDuration()} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";    
    }
}