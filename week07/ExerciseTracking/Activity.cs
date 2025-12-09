using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    protected Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    protected int GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public abstract double GetDistance(); 
    public abstract double GetSpeed(); 
    public abstract double GetPace();  

    protected abstract string GetActivityName();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetActivityName()} " +
               $"({_lengthMinutes} min) - " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min per km";
    }
}
