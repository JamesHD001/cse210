using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.\n");
        List<Exercise> exercises = new List<Exercise>();

        exercises.Add(new Running(5.0, "03 Nov 2022", 30));
        exercises.Add(new Cycling("04 Nov 2022", 45, 20.0));
        exercises.Add(new Swimming("05 Nov 2022", 40, 30));

        foreach (Exercise e in exercises)
        {
            Console.WriteLine(e.GetSummary());
        }
    }
}