using System;
using System.Collections.Generic;

//deriving from Org
public class Cjc : Org
{
    //Properties to Cjc
    public Cjc(List<string> leadership, List<string> areas, List<string> groups, int age, string briefHistory, List<string> articles, string sector, string leader)
        : base("Cjc", new List<string>(), "Introduction for Cjc", "2023", leadership, areas, groups, age)
    {
        BriefHistory = briefHistory;
        Articles = articles;
        Sector = sector;
        Leader = leader;
    }

    public string BriefHistory { get; set; }
    public List<string> Articles { get; set; }
    public string Sector { get; set; }
    public string Leader { get; set; }

//display books and lessons specific to Cjc
    public void GetBooksAndLessons()
    {
        Console.WriteLine("Books and Lessons details...");
    }
//display leadership and areas specific to cjc
    public void GetLeadershipAndAreas()
    {
        Console.WriteLine("Leaders and Areas:");
    }
//overriding Display details from base class to include more details for Cjc
    public override void DisplayDetails()
    {
        //calling base class method
        base.DisplayDetails();
        Console.WriteLine($"Brief History: {BriefHistory}");
        Console.WriteLine($"Sector: {Sector}");
        Console.WriteLine($"Leader: {Leader}");
    }
}
