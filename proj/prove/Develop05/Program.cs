using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main()
    {
        // Example Usage
        List<Goal> goals = new List<Goal>();

        // Ask the user for goal entries
        Console.WriteLine("Enter your goals:");

        while (true)
        {
            Console.Write("Goal Name: ");
            string goalName = Console.ReadLine();

            if (goalName.ToLower() == "exit")
                break;

            Console.Write("Goal Type (Simple, Eternal, or Checklist): ");
            string goalType = Console.ReadLine();

            Goal goal;

            switch (goalType.ToLower())
            {
                case "simple":
                    goal = CreateSimpleGoal(goalName);
                    break;
                case "eternal":
                    goal = CreateEternalGoal(goalName);
                    break;
                case "checklist":
                    goal = CreateChecklistGoal(goalName);
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Please enter Simple, Eternal, or Checklist.");
                    continue;
            }

            goals.Add(goal);
        }

        // Record events to simulate goal completion
        foreach (var goal in goals)
        {
            RecordEvent(goal);
        }

        // Display progress for each goal
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }

        // Save and load progress
        SaveProgress(goals, "progress.txt");
        LoadProgress(goals, "progress.txt");

        // Display progress after loading
        Console.WriteLine("After Loading:");
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }
    }

    static void RecordEvent(Goal goal)
    {
        goal.Complete();
    }

    static void SaveProgress(List<Goal> goals, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
        Console.WriteLine($"Progress saved to {filePath}");
    }

    static void LoadProgress(List<Goal> goals, string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    string line = reader.ReadLine();
                    goals[i].LoadFromString(line);
                }
            }
            Console.WriteLine($"Progress loaded from {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading progress: {ex.Message}");
        }
    }

    static SimpleGoal CreateSimpleGoal(string name)
    {
        Console.Write("Enter Points for Simple Goal: ");
        int points = int.Parse(Console.ReadLine());

        return new SimpleGoal(name, points);
    }

    static EternalGoal CreateEternalGoal(string name)
    {
        Console.Write("Enter Points for Eternal Goal: ");
        int points = int.Parse(Console.ReadLine());

        return new EternalGoal(name, points);
    }

    static ChecklistGoal CreateChecklistGoal(string name)
    {
        Console.Write("Enter Points for Checklist Goal: ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("Enter Completion Target for Checklist Goal: ");
        int completionTarget = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, points, completionTarget);
    }
}
