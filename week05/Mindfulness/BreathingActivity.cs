using System;

public class BreathingActivity : Activity
{
    private int _cyclesCompleted;

    public BreathingActivity() : base(
        "Breathing",
        "This activity helps you relax by guiding breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        _cyclesCompleted = 0;

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(3);

            Console.Write("\nBreathe out...");
            ShowCountDown(3);

            elapsed += 6;
            _cyclesCompleted++;
        }

        DisplayEndingMessage();
        DisplaySessionSummary();
    }

    private void DisplaySessionSummary()
    {
        Console.WriteLine($"\nSession Summary: You completed {_cyclesCompleted} breathing cycles!");
    }
}
