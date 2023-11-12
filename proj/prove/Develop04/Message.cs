using System;

public class Message
{
    private string _username;

    public Message()
    {
        Console.WriteLine("What's your name?");
        _username = Console.ReadLine();
        Console.WriteLine($"Welcome, {_username}");
    }

    private void EndMessageInternal() // Changed to private
    {
        Console.WriteLine("Thank you for participating! Kudos to you.");
    }

    public void EndMessage() // Public method to access the private one
    {
        EndMessageInternal();
    }
}
