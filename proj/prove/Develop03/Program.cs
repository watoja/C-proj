using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        // Adding the John 3:16-18 scripture
        Reference johnReference = new Reference("John 3:16-18");
        List<string> johnText = new List<string>
        {
            "For God so loved the world,",
            "that he gave his only Son,",
            "that whoever believes in him should not perish",
            "but have eternal life.",
            "For God did not send his Son into the world",
            "to condemn the world, but in order that the world",
            "might be saved through him."
        };
        Scripture johnScripture = new Scripture(johnReference, johnText);
        scriptures.Add(johnScripture);

        // Adding the Proverbs 3:5-6 scripture
        Reference proverbsReference = new Reference("Proverbs 3:5-6");
        List<string> proverbsText = new List<string>
        {
            "Trust in the Lord with all your heart,",
            "and do not lean on your own understanding.",
            "In all your ways acknowledge him,",
            "and he will make straight your paths."
        };
        Scripture proverbsScripture = new Scripture(proverbsReference, proverbsText);
        scriptures.Add(proverbsScripture);

        // Continue with your existing code to interact with the scriptures.

        // Going through scriptures
        foreach (Scripture scripture in scriptures)
        {
            // Clearing the console
            Console.Clear();

            // Display the reference and text
            Console.WriteLine($"Scripture Reference: {scripture.Reference.GetFormattedReference()}");
            Console.WriteLine(scripture.GetRenderedText());

            while (!scripture.AreAllWordsHidden())
            {
                
                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    return;

                // Hide 5 words
                scripture.HideRandomWords(5);
                Console.Clear();
                Console.WriteLine($"Scripture Reference: {scripture.Reference.GetFormattedReference()}");
                Console.WriteLine(scripture.GetRenderedText());
            }
        }

        Console.WriteLine("All scriptures are memorized!");
    }
}
