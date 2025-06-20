using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engineer", "Tigo Telecomunications", 2015, 2020);
        Job job2 = new Job("Senior Software Engineer", "Tigo Telecomunications", 2020, 2023);
        Job job3 = new Job("Lead Software Engineer", "Entel Telecommunications", 2023, 2024);

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume.DisplayResume();
    }
}