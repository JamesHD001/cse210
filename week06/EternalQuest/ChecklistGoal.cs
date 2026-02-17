using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            int earnedPoints = int.Parse(GetPoints());
            Console.WriteLine($"Great! You earned {earnedPoints} points for '{GetName()}' (Progress: {_amountCompleted}/{_target})");

            if (IsComplete())
            {
                Console.WriteLine($"Congratulations! You completed the checklist goal '{GetName()}' and earned a bonus of {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine($"Checklist goal '{GetName()}' is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} - {GetDescription()} ({GetPoints()} pts) Progress: {_amountCompleted}/{_target} Bonus: {_bonus}";
    }

    // Helper methods for GoalManager
    public int GetBonus() => _bonus;
    public void SetAmountCompleted(int amount) => _amountCompleted = amount;

    private string GetName() => base.GetStringRepresentation().Split('|')[0];
    private string GetDescription() => base.GetStringRepresentation().Split('|')[1];
    private string GetPoints() => base.GetStringRepresentation().Split('|')[2];
}
