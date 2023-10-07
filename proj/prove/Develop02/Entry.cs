using System;

// Entry class to represent journal entries
public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    // Constructor to create a new entry
    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // Override ToString to display the entry as a string
    public override string ToString()
    {
        return $"{Date}: {Prompt}\nResponse: {Response}\n";
    }
}
