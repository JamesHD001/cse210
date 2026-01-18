using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _days = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _days.Add(entry);
    }

    public void DisplayAllEntries() // renaming suggestion DisplayAllEntries, formerly DisplayAll(); (Proposed by Henry)
    {
        foreach (Entry entry in _days)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _days)
            {
                writer.WriteLine($"{entry._date} | {entry._showSuggestion} | {entry._userResponse}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _days.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._showSuggestion = parts[1];
            entry._userResponse = parts[2];

            _days.Add(entry);
        }
    }
}