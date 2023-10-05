using System;
class Program
{
    static void Main(string[]args)
    {
        DisplayWelcomeMessage();
        string userName =PromptUserName();
        int userNumber =PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        //welcome notice
        Console.WriteLine("welcome!");
    }

    static string PromptUserName()
    {
        //asking for user name
        Console.Write("My name is:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        //inputting user number
        Console.Write("Enter user Number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    
        static int SquareNumber(int number)
        {
            //squaring
            int square = number*number;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, The Square of your number is {square}.");
        }

    }

