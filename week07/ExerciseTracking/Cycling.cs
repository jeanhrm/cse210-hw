using System;

public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(DateTime date, int lengthMinutes, double speedKph)
        : base(date, lengthMinutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance()
    {
        // distance = speed * minutes / 60
        return _speedKph * GetLengthMinutes() / 60.0;
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetPace()
    {
        // pace = minutes / distance
        return GetLengthMinutes() / GetDistance();
    }

    protected override string GetActivityName()
    {
        return "Cycling";
    }
}
