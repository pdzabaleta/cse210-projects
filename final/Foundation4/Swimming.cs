using System;
public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    public override float GetSpeed()
    {
        return  (GetDistance() / GetDuration()) * 60;
    }
    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetActivityType()
    {
        return "Swimming";
    }

    // public override string GetSummary()
    // {
    //     return $"{GetDate()} Swimming ({GetDuration()} min): Distance {GetDistance()} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    // }
}