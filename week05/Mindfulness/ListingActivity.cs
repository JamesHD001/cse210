using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "List things you are grateful for.",
        "List people who inspire you.",
        "List your personal strengths."
    };

    private Random _random = new Random();
    private int _itemsListed;

    public ListingActivity() : base(
        "Listing",
        "This activity helps you reflect by listing items.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("\nStart listing items:");

        List<string> responses = GetListFromUser();
        _itemsListed = responses.Count;

        Console.WriteLine($"You listed {_itemsListed} items!");
        DisplayEndingMessage();
        DisplaySessionSummary();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        return items;
    }

    private void DisplaySessionSummary()
    {
        Console.WriteLine($"\nSession Summary: You listed {_itemsListed} items!");
    }
}
