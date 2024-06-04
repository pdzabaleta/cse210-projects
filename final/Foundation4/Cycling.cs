using System;
public class Cycling : Activity
{
    private float _speed;
    public Cycling(string date, int duration, float speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override float GetSpeed()
    {
        return  _speed;
    }
    public override float GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }
    public override float GetPace()
    {
        return 60 / _speed;;
    }
    public override string GetActivityType()
    {
        return "Cycling";
    }

    // public override string GetSummary()
    // {
    //     return $"{GetDate()} Cycling ({GetDuration()} min): Distance {GetDistance()} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    // }
}