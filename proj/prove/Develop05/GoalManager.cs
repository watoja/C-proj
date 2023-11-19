using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }
    }

    public void CompleteGoal(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            goals[index].Complete();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split(",");
                string goalType = parts[0];
                Goal goal;

                switch (goalType)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(parts[1], int.Parse(parts[2]));
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(parts[1], int.Parse(parts[2]));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]));
                        break;
                    default:
                        continue;
                }

                goal.LoadFromString(line);
                goals.Add(goal);
            }
        }
    }
}
