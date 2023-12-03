using System;
using System.Collections.Generic;

public class BooksAndLessons
{
    public List<string> Books { get; set; }
    public List<string> Temples { get; set; }
    public string MissionaryWork { get; set; }
    public string Institute { get; set; }

    public BooksAndLessons()
    {
        Books = new List<string>();
        Temples = new List<string>();
        MissionaryWork = "";
        Institute = "";
    }
}
