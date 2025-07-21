public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "Clear your mind and breathe slowly.", 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {


            Console.Write("Take a deep breath in...");
            ShowCountdown(5);
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            ShowCountdown(4);
            Console.WriteLine("\n");

        }

        DisplayEndingMessage();
    }
}