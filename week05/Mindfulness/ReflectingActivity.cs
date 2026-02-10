using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a challenge you overcame.",
        "Remember a time you felt proud."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel afterwards?"
    };

    private Random _random = new Random();
    private int _questionsAnswered;
    public ReflectingActivity() : base(
        "Reflecting",
        "This activity helps you reflect on strengths.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("\nThink about the following questions:");

        int elapsed = 0;
        _questionsAnswered = 0;

        while (elapsed < _duration)
        {
            DisplayQuestion();
            elapsed += 5;
            _questionsAnswered++;
        }

        DisplayEndingMessage();
        DisplaySessionSummary();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider this:");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("Press Enter when ready...");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"\n{GetRandomQuestion()}");
        ShowSpinner(5);
    }
    private void DisplaySessionSummary()
    {
        Console.WriteLine($"\nSession Summary: You reflected on {_questionsAnswered} questions!");
    }
}
