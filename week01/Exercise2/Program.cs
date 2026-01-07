using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade?(type only the grade number i.e 65) ");
        int userGrade = int.Parse(Console.ReadLine());
        string letterGrade = ("");
        if (userGrade >= 90)
        {
            letterGrade = ("A");
            Console.WriteLine($"Your grade {userGrade}, is {letterGrade}");
        }
        else if (userGrade >= 80 && userGrade < 90)
        {
            letterGrade = ("B");
            Console.WriteLine($"Your grade {userGrade}, is {letterGrade}");
        }
        else if (userGrade >= 70 && userGrade < 80)
        {
            letterGrade = ("C");
            Console.WriteLine($"Your grade {userGrade}, is {letterGrade}");
        }
        else if (userGrade >= 60 && userGrade < 70)
        {
            letterGrade = ("D");
            Console.WriteLine($"Your grade {userGrade}, is {letterGrade}");
        }
        else
        {
            letterGrade = ("F");
            Console.WriteLine($"Your grade {userGrade}, is {letterGrade}");
        }
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