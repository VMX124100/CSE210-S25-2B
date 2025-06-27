public class Entry
{
    public string _date;
    public string _prompt;
    public string _userEntry;

    public Entry(string prompt, string userEntry)
    {
        _date = System.DateTime.Now.ToString();
        _prompt = prompt;
        _userEntry = userEntry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}, Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_userEntry}");
        Console.WriteLine("");
    }
}