using System;

public class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        double meters = laps * 50;
        double km = meters / 1000.0;
        return km * 0.62;  // convert km to miles
    }

    public override double GetSpeed() => GetDistance() / Duration * 60;

    public override double GetPace() => Duration / GetDistance();
}