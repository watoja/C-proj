using System;
using System.Collections.Generic;

public class Cjc : Org
{
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

    public void GetBooksAndLessons()
    {
        Console.WriteLine("Books and Lessons details...");
    }

    // Add the missing method
    public void GetLeadershipAndAreas()
    {
        Console.WriteLine($"Leadership: {string.Join(", ", Leadership)}");
        Console.WriteLine($"Areas: {string.Join(", ", Areas)}");
    }
}
