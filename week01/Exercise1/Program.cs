using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Whats your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("Whats your last name?");
        string lastName = Console.ReadLine();
        
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}