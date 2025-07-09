class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Romans", 5, 15);
        string scriptureText = "But not as the offence, so also is the free gift. For if through the offence of one many be dead, much more the grace of God, and the gift by grace, which is by one man, Jesus Christ, hath abounded unto many.";

        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words have been hidden.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
        Console.WriteLine("\nThank you for using Scripture Memorizer!");
    }
}