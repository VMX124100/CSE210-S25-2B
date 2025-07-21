
using System.Xml.Serialization;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // Duration in seconds

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine($"How long would you like this activity to last (in seconds)?");
        int input = int.Parse(Console.ReadLine());
        _duration = input;
        Console.Clear();
        Console.WriteLine($"Get ready...");
        ShowSpinner(3);
        Console.Clear();

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.Clear();
    }


    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            {
                Console.Write(s);
                Thread.Sleep(750);
                Console.Write("\b \b"); // Erase the character
                i++;
                if (i >= spinner.Count) i = 0;
            }
        }

    }

    public void ShowCountdown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }
}