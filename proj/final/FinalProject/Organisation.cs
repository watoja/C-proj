using System;
using System.Collections.Generic;

//organisation class
public class Organization
{
    //constructor for properties
    public Organization(string name, List<string> type, string introduction, string year, List<string> leadership, List<string> areas, List<string> groups, int age)
    {
        Name = name;
        Type = type;
        Introduction = introduction;
        Year = year;
        Leadership = leadership;
        Areas = areas;
        Groups = groups;
        Age = age;
    }

    public string Name { get; set; }
    public List<string> Type { get; set; }
    public string Introduction { get; set; }
    public string Year { get; set; }
    public List<string> Leadership { get; set; }
    public List<string> Areas { get; set; }
    public List<string> Groups { get; set; }
    public int Age { get; set; }

//displaying details for organisation
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Organization Details: {Name}, {Year}, {Introduction}");
    }
}
