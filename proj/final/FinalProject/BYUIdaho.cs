using System;
using System.Collections.Generic;

public class BYUIdaho : EducationalOrganization
{
    public strin Sector {get;set;}
    public string System { get; set; }
    public List<string> Certificates { get; set; }

    public BYUIdaho()
    {
        Certificates = new List<string>();
        System = "";
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Type: {string.Join(", ", Type)}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Certificates: {string.Join(", ", Certificates)}");
        Console.WriteLine($"System: {System}");
    }
}
