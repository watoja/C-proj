using System.Collections.Generic;

public class BYUIdaho : Organization
{
    public BYUIdaho(string name, List<string> type, string introduction, string year, List<string> certificates, string systemName, List<string> groups, int age)
        : base(name, type, introduction, year, new List<string>(), new List<string>(), groups, age)
    {
        Certificates = certificates;
        SystemName = systemName;
    }
    public List<string> Certificates {get; set;}
    public string SystemName {get; set;}
}
