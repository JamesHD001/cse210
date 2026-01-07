using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade?(type only the grade number i.e 65) ");
        int userGrade = int.Parse(Console.ReadLine());
        if (userGrade >= 90)
        {
            Console.Write($"Your grade {userGrade}, is A");
        }
        else if (userGrade >= 80 && userGrade < 90)
        {
            Console.Write($"Your grade {userGrade}, is B");
        }
        else if (userGrade >= 70 && userGrade < 80)
        {
            Console.Write($"Your grade {userGrade}, is C");
        }
        else if (userGrade >= 60 && userGrade < 70)
        {
            Console.Write($"Your grade {userGrade}, is D");
        }
        else
        {
            Console.Write($"Your grade {userGrade}, is F");
            Console.WriteLine("Try harder next semester! I know you can do it.");
        }
        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the test/exam");
            Console.WriteLine("Keep Up The Work!");
        }
        else
        {
            Console.WriteLine("Unfortunately your grade is too low.");
            Console.WriteLine("Try harder next time, you can do it!");            
        }
    }
}