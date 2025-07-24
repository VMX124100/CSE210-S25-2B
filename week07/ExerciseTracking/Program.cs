using System;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0),
            new CyclingActivity(new DateTime(2022, 11, 3), 45, 15.0),
            new SwimmingActivity(new DateTime(2022, 11, 3), 20, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}