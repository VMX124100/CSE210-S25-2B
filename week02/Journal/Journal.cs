public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date}, Prompt: {entry._prompt}");
                outputFile.WriteLine($"Entry: {entry._userEntry}");
                outputFile.WriteLine(""); 
            }
        }
    }

    public void LoadFromFile(string filename )
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}