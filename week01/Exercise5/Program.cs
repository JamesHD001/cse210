using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine();

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int results = SquareNumber(number);
        DisplayResults(results, name);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        int userNumber =int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber * userNumber;
        return squaredNumber;
    }
    static void DisplayResults(int squaredNumber, string userName)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}