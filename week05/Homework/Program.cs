using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("David Martinez", "English paper #1");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("David Martinez", "Math Assignment #1", "Section 7.3", "Problems 8-19");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("David Martinez", "History Essay", "America Colonization");

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();
    }
}