using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Journal class for managing journal entries
public class Journal
{
    private List<Entry> Entries { get; set; } = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(string prompt, string response, string date)
    {
        Entries.Add(new Entry(prompt, response, date));
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }

    // Save journal entries to a CSV file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
        Console.WriteLine("Journal entries saved to file.");
    }

    // Load journal entries from a CSV file
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            var lines = File.ReadAllLines(filename);
            Entries = lines.Select(line =>
            {
                var parts = line.Split(',');
                return new Entry(parts[1], parts[2], parts[0]);
            }).ToList();
            Console.WriteLine("Journal entries loaded from file.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}
