using System;

public class SimpleGoal : Goal
{
    private bool _isComplete; // Track if this goal is done

    public SimpleGoal(string name, string description, string points) 
        : base(name, description, points)
    {
        _isComplete = false; // Initially not complete
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            int earnedPoints = int.Parse(GetPoints());
            Console.WriteLine($"Congratulations! You have earned {earnedPoints} points for completing '{GetName()}'!");
            _isComplete = true;
        }
        else
        {
            Console.WriteLine($"This goal '{GetName()}' has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {GetName()} - {GetDescription()} ({GetPoints()} points)";
    }

    private string GetName() => base.GetStringRepresentation().Split('|')[0];
    private string GetDescription() => base.GetStringRepresentation().Split('|')[1];
    private string GetPoints() => base.GetStringRepresentation().Split('|')[2];
}
