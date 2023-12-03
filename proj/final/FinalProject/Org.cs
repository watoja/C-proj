public class Org
{
    public string Year {get; set;}
    public string Name {get; set;}
    public string Introduction { get;set;}
    public string Type {get;set;}
    public List<string> Leadership { get; set; }
    public List<string> Areas { get; set; }
    public List<string> Groups { get; set; }
    public int Age { get; set; }

    public void GetLeadershipAndAreas()
    {
        Console.WriteLine("Leadership: " + string.Join(", ", Leadership));
        Console.WriteLine("Areas: " + string.Join(", ", Areas));
    }

    public void GetGroupsAndAge()
    {
        Console.WriteLine("Groups: " + string.Join(", ", Groups));
        Console.WriteLine("Age: " + Age);
    }
}

public class Cjc : Org
{
    public string BriefHistory { get; set; }
    public List<string> Articles { get; set; }
    public new List<string> Type { get; set; }
    public string Leader { get; set; }

    public void GetMoreAbout()
    {
        Console.WriteLine($"Brief History: {BriefHistory}");
        Console.WriteLine($"Beliefs: {string.Join(", ", Articles)}")
    }

   
}
