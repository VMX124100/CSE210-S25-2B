public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "Reflect on the good things in your life.", 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You might begin in:");
        ShowCountdown(5);
        Console.WriteLine("");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void GetListFromUser()
    {


        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items.");
        Console.WriteLine("");
    }

}