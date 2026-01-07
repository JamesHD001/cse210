using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.WriteLine("Welcome To The Guess The Magic Number Game");
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);
        Console.Write("What is the Magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        int userGuess = 0;
        do
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            if (userGuess < magicNumber)
            {
                 Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }   while (userGuess != magicNumber);

        Console.WriteLine("You guessed it!");
    }
}