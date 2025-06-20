class Resume
{
public String _name;
public List<Job> _jobs = new List<Job>();


    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine();
        Console.WriteLine("Jobs:");
        Console.WriteLine();
        foreach (Job job in _jobs)
        {
            job.DisplayJobInfo();
        }
    }
}
