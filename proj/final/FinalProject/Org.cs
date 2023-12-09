using System;
using System.Collections.Generic;

public class Org : Organization
{
    public Org(string name, List<string> type, string introduction, string year, List<string> leadership, List<string> areas, List<string> groups, int age)
        : base(name, type, introduction, year, leadership, areas, groups, age)
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
}
