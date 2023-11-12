// Breathing.cs
using System;
using System.Threading;

public class Breathing : Message
{
    public void StartBreathingExercise()
    {
        Console.WriteLine("Welcome to the Breathing Exercise!");
        Console.WriteLine("This exercise will help you pace your breathing. Get ready for a deep breath session.");
        Console.WriteLine("Breathe deeply for the next 30 seconds.");

        DateTime startTime = DateTime.Now;
        TimeSpan elapsedTime;

        while ((elapsedTime = DateTime.Now - startTime).TotalSeconds < 30)
        {
            Console.Write("Breathe in... ");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("Hold... ");
            Thread.Sleep(1000); // Pause for 1 second
            Console.WriteLine("Breathe out... ");
            Thread.Sleep(1000); // Pause for 1 second
        }

        Console.WriteLine("Breathing exercise completed!");
    }
}
