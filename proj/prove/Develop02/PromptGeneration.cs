using System;
using System.Collections.Generic;

// PromptGeneration class for generating prompts
public class PromptGeneration
{
    private List<string> Prompts { get; set; } = new List<string>();
    private int CurrentIndex { get; set; } = 0;

    // Constructor to initialize prompts
    public PromptGeneration()
    {
        // Initialize prompts
        Prompts.Add("What is the Day today?");
        Prompts.Add("What is your goal today?");
        Prompts.Add("How are you going to accomplish it?");
        Prompts.Add("How have you felt about your experience today?");
        Prompts.Add("At a rate of 1-10, rate your success.");
        Prompts.Add("What can you do better?");
        Prompts.Add("When are you doing this again?");
        Prompts.Add("The greatness of planning is execution!");

    }

    // Generate the next prompt in order
    public string GenerateNextPrompt()
    {
        if (CurrentIndex < Prompts.Count)
        {
            string prompt = Prompts[CurrentIndex];
            CurrentIndex++;
            return prompt;
        }
        else
        {
            // You can decide what to do when all prompts have been generated.
            // For now, we'll simply reset the index to start over.
            CurrentIndex = 0;
            return GenerateNextPrompt();
        }
    }
}
