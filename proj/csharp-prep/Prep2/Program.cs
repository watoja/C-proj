using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string first = Console.ReadLine();

        Console.Write("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {first}, {first}  {last}. ");

        Console.Write("What is your % mark?");
        string mark = Console.ReadLine();
        int score = int.Parse(mark);

        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is:{letter}");
        if (score >= 70)
        {
            Console.WriteLine("Congratulations, you PASSED!");
        }
        else
        {
            Console.WriteLine("YOU FAILED! BETTER LUCK NEXT TIME.");
        }
    }
}