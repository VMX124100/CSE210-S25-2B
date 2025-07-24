using System;

public class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => GetDistance() / Duration * 60;

    public override double GetPace() => Duration / GetDistance();
}