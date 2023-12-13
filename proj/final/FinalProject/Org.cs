using System;
using System.Collections.Generic;

//Org.cs deriving from Organisation.cs
public class Org : Organization
{
    public Org(string name, List<string> type, string introduction, string year, List<string> leadership, List<string> areas, List<string> groups, int age)
        : base(name, type, introduction, year, leadership, areas, groups, age)
    {
    }
}
