using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

public class Reflection : Message
{
    private int durationInSeconds;
    private Random random;
    private List<string> prompts;
    private List<string> questions;

    public Reflection(int durationInSeconds)
    {
        this.durationInSeconds = durationInSeconds;
        random = new Random();
        InitializePrompts();
        InitializeQuestions();
    }

    public void StartActivity()
    {
        Console.WriteLine("Welcome to the Reflection Activity!");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        TimeSpan elapsedTime;

        while (true)
        {
            if ((elapsedTime = DateTime.Now - startTime).TotalSeconds >= durationInSeconds)
            {
                Console.WriteLine("Activity completed!");
                break;
            }

            string randomPrompt = GetRandomPrompt();
            Console.WriteLine(randomPrompt);

            foreach (string question in GetRandomQuestions())
            {
                Console.WriteLine(question);
                DisplaySpinner(3); // Pause for 3 seconds
            }
        }
    }

    public string GetRandomPrompt() // Make it public
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public IEnumerable<string> GetRandomQuestions() // Make it public
    {
        var randomQuestions = questions.OrderBy(q => random.Next()).Take(3);
        return randomQuestions;
    }

    private void InitializePrompts()
    {
        prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }

    private void InitializeQuestions()
    {
        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    private void DisplaySpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(" ");
            Thread.Sleep(250);
            Console.Write("- ");
            Thread.Sleep(250);
            Console.Write("\\ ");
            Thread.Sleep(250);
            Console.Write("| ");
            Thread.Sleep(250);
        }

        Console.WriteLine();
    }
}
