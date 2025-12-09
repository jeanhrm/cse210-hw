using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceMeters = _laps * 50;
        return distanceMeters / 1000.0; // km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60.0;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }

    protected override string GetActivityName()
    {
        return "Swimming";
    }
}
