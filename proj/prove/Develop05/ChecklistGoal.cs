using System;

public class ChecklistGoal : Goal
{
    private int completionTarget;
    private int completions;

    public ChecklistGoal(string name, int points, int completionTarget) : base(name)
    {
        this.points = points;
        this.completionTarget = completionTarget;
        this.completions = 0;
    }

    public override void Complete()
    {
        completions++;
        Console.WriteLine($"Goal completed:  (+{points} points)");
        if (completions == completionTarget)
        {
            points += 500; // Bonus points for completing the checklist
            Console.WriteLine($"Bonus: Checklist completed (+500 points)!");
        }
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($" (Completed {completions}/{completionTarget} times, {points} points)");
    }

    public override string GetSaveString()
    {
        return $"{base.GetSaveString()},{completionTarget},{completions}";
    }

    public override void LoadFromString(string data)
    {
        base.LoadFromString(data);
        string[] parts = data.Split(",");
        completionTarget = int.Parse(parts[2]);
        completions = int.Parse(parts[3]);
    }

    
}
