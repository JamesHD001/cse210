public class Goal
{
    private string _shortName = "";
    private string _description = "";
    private string _points = "";

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        string earnedPoints = _points;
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
    }

    public virtual bool IsComplete()
    {
        return true; //to be changed with logic
    }

    public virtual string GetDetailsString()
    {
        return $"Name: {_shortName}\nDescription: {_description}\nPoints: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }
}