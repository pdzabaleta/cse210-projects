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
    public abstract string GetSummary();
}