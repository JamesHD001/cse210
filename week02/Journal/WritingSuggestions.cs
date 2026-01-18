using System;
using System.Collections.Generic;

public class WritingSuggestions
{
    private List<string> _suggestions = new List<string>
    {
        "Write about the best part of your morning routine.",
        "Describe a meal you enjoyed today and why it mattered.",
        "Reflect on one person who made your day easier.",
        "Write about a small challenge you overcame today.",
        "List three things you’re grateful for right now.",
        "Describe a conversation that made you smile.",
        "Write about something you noticed on your commute or walk.",
        "Reflect on how you managed stress today.",
        "Write about a goal you want to achieve tomorrow.",
        "Describe a moment of peace or calm you experienced.",
        "Write about a task you procrastinated on but finally completed.",
        "Reflect on a time you helped someone today.",
        "Write about something new you learned.",
        "Describe a place you visited today, even if ordinary.",
        "Write about a sound that stood out to you today.",
        "Reflect on a moment when you felt proud.",
        "Write about a time you laughed today.",
        "Describe something you saw that inspired you.",
        "Write about a mistake you made and what you learned.",
        "Reflect on how you spent your free time today.",
        "Write about a habit you’d like to improve.",
        "Describe a moment when you felt connected to someone.",
        "Write about something that surprised you today.",
        "Reflect on a time you felt calm despite chaos.",
        "Write about a small act of kindness you witnessed.",
        "Describe a moment when you felt creative.",
        "Write about something you’re looking forward to.",
        "Reflect on how you balanced work and rest today.",
        "Write about a moment when you felt grateful for technology.",
        "Describe the best part of your day in detail.",
        "What could you have done better today? "
    };

    private Random GetRandomSuggestion = new Random();

    public string RandomSuggestion()
    {
        int index = GetRandomSuggestion.Next(_suggestions.Count);
        return _suggestions[index];
    }
}
