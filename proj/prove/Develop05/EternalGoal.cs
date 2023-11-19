using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name)
    {
        this.points = points;
    }

    public override void Complete()
    {
        Console.WriteLine("Eternal goals are continuos.");
    }

}

