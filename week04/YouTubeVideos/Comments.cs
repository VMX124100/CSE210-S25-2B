public class Comment
{
    public string UserName;
    public string Text;

    public Comment(string userName, string text)
    {
        UserName = userName;
        Text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"-{UserName}: {Text}");
    }

}
