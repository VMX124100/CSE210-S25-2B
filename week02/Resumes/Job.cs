class Job
{
    string _company;
    int _yearStarted;
    int _yearEnded;
    string _title;


    public Job(string title, string company, int yearStarted, int yearEnded)
    {
        _title = title;
        _company = company;
        _yearStarted = yearStarted;
        _yearEnded = yearEnded;
    }

    public void DisplayJobInfo()
    {
        Console.WriteLine($"Title: {_title}, Company: {_company}, Years: {_yearStarted} - {_yearEnded}");
        Console.WriteLine();
    }
}