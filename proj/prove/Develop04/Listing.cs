using System;
using System.Collections.Generic;

public class Listing : Message
{
    private List<string> Prompts { get; } = new List<string>();
    private int CurrentIndex { get; set; } = 0;

    public Listing()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Prompts.Add("Who are people that you appreciate?");
        Prompts.Add("What are personal strengths of yours?");
        Prompts.Add("Who are people that you have helped this week?");
        Prompts.Add("When have you felt the Holy Ghost this month?");
        Prompts.Add("Who are some of your personal heroes?");
    }

    public string ChoosePrompt()
    {
        if (CurrentIndex < Prompts.Count)
        {
            string prompt = Prompts[CurrentIndex];
            CurrentIndex++;
            return prompt;
        }
        else
        {
            CurrentIndex = 0;
            return ChoosePrompt();
        }
    }
}
