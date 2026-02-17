using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine("\nWelcome to Eternal Quest!");
        Console.WriteLine("Your journey to achieving goals begins now.\n");

        GoalManager manager = new GoalManager();

        Console.WriteLine("Do you want to load previous goals? (y/n)");
        string loadChoice = Console.ReadLine()?.ToLower();
        if (loadChoice == "y")
        {
            manager.LoadGoals();
        }

        manager.Start();

        Console.WriteLine("\nThank you for playing Eternal Quest!");
        manager.DisplayPlayerInfo();
        Console.WriteLine("Remember: Every small step counts toward your eternal journey.");
    }
}
