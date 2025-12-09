using System;

public class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, int lengthMinutes, double distanceKm)
        : base(date, lengthMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        // speed = (distance / minutes) * 60
        return (_distanceKm / GetLengthMinutes()) * 60.0;
    }

    public override double GetPace()
    {
        // pace = minutes / distance
        return GetLengthMinutes() / _distanceKm;
    }

    protected override string GetActivityName()
    {
        return "Running";
    }
}
