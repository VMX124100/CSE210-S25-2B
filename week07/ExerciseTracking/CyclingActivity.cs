using System;

public class CyclingActivity : Activity
{
    private double speed;

    public CyclingActivity(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => speed * Duration / 60;

    public override double GetSpeed() => speed;

    public override double GetPace() => 60 / speed;
}