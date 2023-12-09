using System;
using System.Collections.Generic;

public class BooksAndLessons
{
    public List<string> Books { get; set; }
    public List<string> Temples { get; set; }
    public string MissionaryWork { get; set; }
    public string Institute { get; set; }

    // Additional properties or methods can be added here

    public BooksAndLessons()
    {
        Books = new List<string>();
        Temples = new List<string>();
        MissionaryWork = "";
        Institute = "";
    }


    

    // You can add more methods based on your requirements
}
