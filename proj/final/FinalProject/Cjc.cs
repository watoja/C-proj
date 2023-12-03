using System;
using System.Collections.Generic;

public class Cjc : Org
{
    
    public string History { get; set; }
    public List<string> Beliefs { get; set; }
    public string Type { get; set; } // This Type property is from Org class
    public string Leaders { get; set; }

    public string Sector{get;set;}


    public void GetBooksAndLessons() // Explicitly implementing the method
    {
        Console.WriteLine("Retrieving Books and Lessons Information...");
        // Add your implementation to get Books and Lessons information
    }
}
