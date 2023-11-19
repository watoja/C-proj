public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name)
    {
        this.points = points;
    }

    public override void Complete()
    {
        // Since simple goals cannot be marked as completed, do nothing
        
        Console.WriteLine("Simple goals_continuos.");
    }
    public override void DisplayProgress()
    {
        Console.WriteLine("Simple goals are never-ending quests.");
    }

    
    public override string GetSaveString()
    {
        return $"{base.GetSaveString()},{points}";
    }

    public override void LoadFromString(string data)
    {
        base.LoadFromString(data);
        string[] parts = data.Split(",");
        points = int.Parse(parts[2]);
    }
}
