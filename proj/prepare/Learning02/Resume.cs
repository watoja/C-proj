using System;
public class Resume
{
    public string _name;

    //initializing list -List<Job>
    public List<Job>_jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");


        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}