using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "yes";
        while (input == "yes")
        {
            Console.Clear();
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.Write("Would you like to play again?");
                    input = Console.ReadLine().ToLower();
                }
            }

        }                    
    }
}