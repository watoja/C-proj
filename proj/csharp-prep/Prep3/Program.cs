using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for the magic number.
        Console.Write(" What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        // Ask the user for a guess.
        Console.Write("Make a guess..:");

        int guess = int.Parse(Console.ReadLine());

        // Keep guessing until the user gets it right.
        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            // Get the user's next guess.
            guess = int.Parse(Console.ReadLine());
        }

        // Congratulations!
        Console.WriteLine("Congratulations! ");
    }
}
