using System;
using System.Configuration;

public class Goal
{
    protected string name;
    protected int points;

    public Goal(string name)
    {
        this.name = name;
        this.points = 0;
    }

    public virtual void Complete()
    {
        Console.WriteLine($"Goal completed: {name} (+{points} points)");
    }

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"[ ] {name} ({points} points)");
    }

    public virtual string GetSaveString()
    {
        return $"{name},{points}";
    }

    public virtual void LoadFromString(string data)
    {
        string[] parts = data.Split(",");
        name = parts[0];
        points = int.Parse(parts[1]);
    }
}
