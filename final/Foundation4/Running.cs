using System;
public class Running : Activity
{
    private float _distance;
    public Running(string date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }
    public override float GetSpeed()
    {
        return  (_distance / GetDuration()) * 60 ;
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetPace()
    {
        return GetDuration() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min): Distance {GetDistance()} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}