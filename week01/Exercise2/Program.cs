using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade?(type only the grade number i.e 65) ");
        int userGrade = int.Parse(Console.ReadLine());
        string letterGrade = ("");
        string modifier = "";
        int lastDigit = userGrade % 10;
        
        if (userGrade >= 90)
        {
            letterGrade = ("A");
        }
        else if (userGrade >= 80 && userGrade < 90)
        {
            letterGrade = ("B");
        }
        else if (userGrade >= 70 && userGrade < 80)
        {
            letterGrade = ("C");
        }
        else if (userGrade >= 60 && userGrade < 70)
        {
            letterGrade = ("D");
        }
        else
        {
            letterGrade = ("F");
        }

        if (lastDigit >= 7)
        {
            modifier = ("+");
        }
        else if (lastDigit < 3)
        {
            modifier = ("-");
        }
        if (letterGrade == "A" && modifier == "+")
        {
            modifier = "";
        }
        else if (letterGrade == "F")
        {
            modifier = "";
        }
        Console.WriteLine($"Your grade {userGrade}, is {letterGrade}{modifier}");


        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the test/exam");
            Console.WriteLine("Keep Up The Good Work!");
        }
        else
        {
            Console.WriteLine("Unfortunately you failed the test/exam.");
            Console.WriteLine("Try harder next time! You can do it.");            
        }
    }
}