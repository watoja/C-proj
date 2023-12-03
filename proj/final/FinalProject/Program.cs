using System;
public class Program
{
    static void Main()
    {
        EducationalOrganization organization = new BYUIdaho
        {
            Name = "ExampleOrg",
            Sector = new List<string> { "Non-profit", "Education" },
            Introduction = "This is an example organization.",
            Year = "2023",
            Certificates = new List<string> { "Certificate1", "Certificate2" },
            System = "SomeSystem"
        };

        organization.DisplayDetails();

        Org cjc = new Cjc
        {
            Leadership = new List<string> { "Leader1", "Leader2" },
            Areas = new List<string> { "Area1", "Area2" },
            Groups = new List<string> { "Group1", "Group2" },
            Age = 20,
            BriefHistory = "Brief history of CJC",
            Articles = new List<string> { "Belief1", "Belief2" },
            Sector = "Organization",
            Leader = "CJC Leader"
        };

        cjc.GetLeadershipAndAreas();
        ((Cjc)cjc).GetBooksAndLessons(); 

        // Using polymorphism to display organization details
        organization = new Org
        {
            Name = "AnotherOrg",
            Type = new List<string> { "Non-profit", "Community" },
            Introduction = "Another organization.",
            Year = "2023",
            Leadership = new List<string> { "Leader3", "Leader4" },
            Areas = new List<string> { "Area3", "Area4" },
            Groups = new List<string> { "Group3", "Group4" },
            Age = 25
        };

        organization.DisplayDetails();
    }
}
