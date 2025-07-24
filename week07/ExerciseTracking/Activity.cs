using System;

public abstract class Activity
{
    private DateTime _date;
    private int _duration;

    protected Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime Date => _date;
    public int Duration => _duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string dateStr = _date.ToString("dd MMM yyyy");
        string name = GetType().Name.Replace("Activity", "");
        double dist = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        return string.Format(
            "{0} {1} ({2} min): Distance {3:F1} miles, Speed {4:F1} mph, Pace: {5:F1} min per mile",
            dateStr, name, _duration, dist, speed, pace
        );
    }
}