using System;
using System.Collections.Generic;

public class BooksAndLessons
{
    private List<string> books;
    private List<string> temples;
    private string missionaryWork;
    private string institute;

    public List<string> Books
    {
        get { return new List<string>(books); }
        set { books = value ?? new List<string>(); }
    }

    public List<string> Temples
    {
        get { return new List<string>(temples); }
        set { temples = value ?? new List<string>(); }
    }

    public string MissionaryWork
    {
        get { return missionaryWork; }
        set { missionaryWork = value ?? string.Empty; }
    }

    public string Institute
    {
        get { return institute; }
        set { institute = value ?? string.Empty; }
    }

    public BooksAndLessons()
    {
        books = new List<string>();
        temples = new List<string>();
        missionaryWork = "";
        institute = "";
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Books and Lessons Details:");
        Console.WriteLine($"Books: {string.Join(", ", Books)}");
        Console.WriteLine($"Temples: {string.Join(", ", Temples)}");
        Console.WriteLine($"Missionary Work: {MissionaryWork}");
        Console.WriteLine($"Institute: {Institute}");
    }
}
