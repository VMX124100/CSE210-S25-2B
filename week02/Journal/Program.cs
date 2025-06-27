class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        Journal journal = new Journal();

        do
        {
            Console.WriteLine("Wecome to your personal electronic journal!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write\n2. Display\n3. Save\n4. Load\n5. Quit");
            Console.WriteLine("What would you like to do?");
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Prompt prompt = new Prompt();
                    string promptToDisplay = prompt.GetRandomPrompt();
                    Console.WriteLine(promptToDisplay);
                    string userEntry = Console.ReadLine();
                    journal.AddEntry(new Entry(promptToDisplay, userEntry));
                    Console.WriteLine("");

                    break;

                case 2:
                    Console.Clear();
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.Write("Please enter your file name: ");
                    string filename = Console.ReadLine() + ".txt";
                    journal.SaveToFile(filename);
                    break;

                case 4:
                    Console.Write("Please enter your file name: ");
                    filename = Console.ReadLine() + ".txt";
                    Console.Clear();
                    journal.LoadFromFile(filename);
                    break;

                case 5:
                    Console.WriteLine("\nThanks for using the Journal, have a great day!");
                    break;

                default:
                    Console.WriteLine("Please enter a number between 1 and 5.");
                    break;
            }

        } while (userInput != 5);

    }
}