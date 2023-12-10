using System;
using System.Collections.Generic;
using System.IO;

public class MainProgram
{
    static void Main()
    {
        // Prompt the user for organization information
        Organization organization = GetOrganizationInformation();

        // Display organization details
        organization.DisplayDetails();

        // Prompt the user for CJC information
        Cjc cjc = GetCjcInformation();

        // Display CJC details
        cjc.GetLeadershipAndAreas();
        cjc.GetBooksAndLessons();  // Call the new method to get Books and Lessons information

        // Using polymorphism to display organization details
        Organization org = GetOrgInformation();

        // Display organization details
        org.DisplayDetails();

        // Save organization information to a file
        SaveToFile(organization);
        SaveToFile(cjc);
        SaveToFile(org);
    }

    static Organization GetOrganizationInformation()
    {
        Console.WriteLine("About Byu-I:");

        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Types (comma-separated): ");
        List<string> types = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Introduction: ");
        string introduction = Console.ReadLine() ?? "";

        Console.Write("Year: ");
        string year = Console.ReadLine() ?? "";

        Console.Write("Certificates (comma-separated): ");
        List<string> certificates = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("System: ");
        string system = Console.ReadLine() ?? "";

        Console.Write("Groups (comma-separated): ");
        List<string> groups = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Age: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.Write("Invalid input. Please enter a valid age: ");
        }

        return new BYUIdaho(name, types, introduction, year, certificates, system, groups, age);
    }

    static Cjc GetCjcInformation()
    {
        Console.WriteLine("\nThe Church of Jesus Christ of Latter-day Saints:");

        Console.Write("Leadership : ");
        List<string> leadership = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Areas : ");
        List<string> areas = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Groups: ");
        List<string> groups = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Brief History: ");
        string briefHistory = Console.ReadLine() ?? "";

        Console.Write("Articles: ");
        List<string> articles = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Sector: ");
        string sector = Console.ReadLine() ?? "";

        Console.Write("Leader: ");
        string leader = Console.ReadLine() ?? "";

        return new Cjc(leadership, areas, groups, age, briefHistory, articles, sector, leader);
    }

    static Organization GetOrgInformation()
    {
        Console.WriteLine("\nEnter organization information :");

        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Types : ");
        List<string> types = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Introduction: ");
        string introduction = Console.ReadLine() ?? "";

        Console.Write("Year: ");
        string year = Console.ReadLine() ?? "";

        Console.Write("Leadership: ");
        List<string> leadership = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Areas : ");
        List<string> areas = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Groups : ");
        List<string> groups = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");

        return new Org(name, types, introduction, year, leadership, areas, groups, age);
    }

    static BooksAndLessons GetBooksAndLessonsInformation()
    {
        Console.WriteLine("\nEnter Books and Lessons Information:");

        Console.Write("Books : ");
        List<string> books = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Temples : ");
        List<string> temples = (Console.ReadLine()?.Split(',') ?? Array.Empty<string>()).ToList();

        Console.Write("Missionary Work: ");
        string missionaryWork = Console.ReadLine() ?? "";

        Console.Write("Institute: ");
        string institute = Console.ReadLine() ?? "";

        return new BooksAndLessons
        {
            Books = books,
            Temples = temples,
            MissionaryWork = missionaryWork,
            Institute = institute
        };
    }

    static void SaveToFile(Organization organization)
    {
        if (organization != null)
        {
            // Save organization information to a file ("OrganizationInfo.txt")
            using (StreamWriter writer = new StreamWriter("OrganizationInfo.txt", true))
            {
                writer.WriteLine($"Organization Details:");
                writer.WriteLine($"Name: {organization.Name}");
                writer.WriteLine($"Types: {string.Join(", ", organization.Type)}");
                writer.WriteLine($"Introduction: {organization.Introduction}");
                writer.WriteLine($"Year: {organization.Year}");
                writer.WriteLine($"Leadership: {string.Join(", ", organization.Leadership)}");
                writer.WriteLine($"Areas: {string.Join(", ", organization.Areas)}");
                writer.WriteLine($"Groups: {string.Join(", ", organization.Groups)}");
                writer.WriteLine($"Age: {organization.Age}");
                writer.WriteLine();
            }

            Console.WriteLine("Saved to file.");
        }
        else
        {
            Console.WriteLine("Organization information is null. Cannot save to file.");
        }
    }

    static void SaveToFile(BooksAndLessons booksAndLessons)
    {
        if (booksAndLessons != null)
        {
            // Save Books and Lessons information to a file ("BooksAndLessonsInfo.txt")
            using (StreamWriter writer = new StreamWriter("BooksAndLessonsInfo.txt", true))
            {
                writer.WriteLine($"Books and Lessons Details:");
                writer.WriteLine($"Books: {string.Join(", ", booksAndLessons.Books)}");
                writer.WriteLine($"Temples: {string.Join(", ", booksAndLessons.Temples)}");
                writer.WriteLine($"Missionary Work: {booksAndLessons.MissionaryWork}");
                writer.WriteLine($"Institute: {booksAndLessons.Institute}");
                writer.WriteLine();
            }

            Console.WriteLine("Books and Lessons information saved to file.");
        }
        else
        {
            Console.WriteLine("Books and Lessons information is null. Cannot save to file.");
        }
    }
}
