// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Listing listing = new Listing();
        Breathing breathing = new Breathing();
        Reflection reflection;

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Mindful App:");
            Console.WriteLine("1. Start Breathing exercise");
            Console.WriteLine("2. Start the Reflection exercise");
            Console.WriteLine("3. Start the Listing exercise");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                {
                    breathing.StartBreathingExercise();
                }
                else if (choice == 2)
                {
                    Console.Write("Enter the duration for the reflection activity in seconds: ");
                    if (int.TryParse(Console.ReadLine(), out int durationInSeconds))
                    {
                        reflection = new Reflection(durationInSeconds);
                        reflection.StartActivity();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number of seconds.");
                    }
                }
                else if (choice == 3)
                {
                    string prompt = listing.ChoosePrompt();
                    Console.WriteLine(prompt);
                    Console.WriteLine("Answer here:"); // user types their answer here
                    string response = Console.ReadLine();
                    // Process the response or save it as needed
                }
                else if (choice == 4)
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid option, Please Try Again");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
