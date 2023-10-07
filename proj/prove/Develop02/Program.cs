using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Journal class to manage journal entries
        Journal journal = new Journal();

        // Define the filename for saving and loading journal entries
        string filename = "journal.csv";

        // Create an instance of the PromptGeneration class for generating prompts
        PromptGeneration promptGenerator = new PromptGeneration();

        // Variable to control program execution
        bool exit = false;

        // Main program loop
        while (!exit)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your option number objectively:");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                {
                    // Generate a Next prompt and get user's response
                    string date = DateTime.Now.ToString();
                    string prompt = promptGenerator.GenerateNextPrompt();

                    Console.WriteLine(prompt);
                    Console.WriteLine("Your response: ");
                    string response = Console.ReadLine();

                    // Add the entry to the journal
                    journal.AddEntry(prompt, response, date);
                }
                else if (choice == 2)
                {
                    // Display all journal entries
                    journal.DisplayEntries();
                }
                else if (choice == 3)
                {
                    // Save journal entries to a file
                    journal.SaveToFile(filename);
                }
                else if (choice == 4)
                {
                    // Load journal entries from a file
                    journal.LoadFromFile(filename);
                }
                else if (choice == 5)
                {
                    // Exit the program
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }
        }
    }
}
