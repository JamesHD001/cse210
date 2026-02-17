using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
        : base(name, description, points)
    {
        // No extra attributes needed for eternal goals
    }

    public override void RecordEvent()
    {
        int earnedPoints = int.Parse(GetPoints());
        Console.WriteLine($"Great job! You earned {earnedPoints} points for '{GetName()}'! Keep going, this goal never ends!");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} - {GetDescription()} ({GetPoints()} pts) Eternal goal: never complete";
    }

    // Helper methods for GoalManager
    private string GetName() => base.GetStringRepresentation().Split('|')[0];
    private string GetDescription() => base.GetStringRepresentation().Split('|')[1];
    private string GetPoints() => base.GetStringRepresentation().Split('|')[2];
}
