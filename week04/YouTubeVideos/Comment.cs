using System;

public class Comment
{
    public string _commenterName;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName}: {_text}");
    }
}
