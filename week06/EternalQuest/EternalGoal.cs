public class EternalGoal : Goal
{
    private int _timesRecorded;

    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _timesRecorded = 0;
    }

    public override void RecordEvent()
    {
        // Eternal goals never complete, but count how many times the event occurs.
        _timesRecorded++;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete.
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Times Recorded: {_timesRecorded}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetShortName()}|{GetPoints()}|{_timesRecorded}";
    }

    public int GetTimesRecorded()
    {
        return _timesRecorded;
    }
}
