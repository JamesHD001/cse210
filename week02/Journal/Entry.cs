using System;

public class Entry
{
    public string _date;
    public string _showSuggestion; //Renaming suggestion _showSuggestion formerly _showText (Proposed by Henry)
    public string _userResponse; //Renaming suggestion _userResponse formerly _userText (Proposed by Henry)

    public void DisplayEntry() //Changed the display method for clarity (Proposed by Henry)
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"Prompt: {_showSuggestion}");
        Console.WriteLine($"Response: {_userResponse}");
        Console.WriteLine();
    }
}