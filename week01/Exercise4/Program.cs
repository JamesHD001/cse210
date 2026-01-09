using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();
        Console.WriteLine("Welcome to the List Practice Program");
        Console.WriteLine();
        List <int> numbers = new List<int>();
        int userNumbers;
        int numbersSum = 0;
        int numbersAverage = 0;
        int largestNumber = 0;
        int smallPositive = int.MaxValue;
        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            userNumbers = int.Parse(Console.ReadLine());
            if (userNumbers != 0)
            {
                numbers.Add(userNumbers);
            }
        } while (userNumbers != 0);

        foreach (int number in numbers)
        {
            numbersSum += number;
            if (number > largestNumber)
            {
                largestNumber =  number;   
            }
            if (number > 0  && number < smallPositive)
            {
                smallPositive = number;
            }
        }
        numbersAverage = numbersSum / numbers.Count;
        numbers.Sort();
        Console.Write("The sum is: ");
        Console.WriteLine(numbersSum);
        Console.Write("The average is: ");
        Console.WriteLine(numbersAverage);
        Console.Write("The largest number is: ");
        Console.WriteLine(largestNumber);
        Console.Write("The smallest positive numbere is: ");
        Console.WriteLine(smallPositive);
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();
        Console.WriteLine("Exiting the List Practice Program...");
    }
}