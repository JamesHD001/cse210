/*
Exceeded Requirements:
- Added SaveToFile and LoadFromFile
- Added more than 30 unique writing prompts (well beyond the minimum requirement),
  improving the usefulness of the program.
- Added basic validation for menu input to handle invalid user choices properly.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        WritingSuggestions suggestion = new WritingSuggestions();

        while (true)
        {
            Console.Write("Choose an option: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._showSuggestion = suggestion.RandomSuggestion();

                Console.WriteLine(entry._showSuggestion);
                Console.Write("> ");
                entry._userResponse = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAllEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting the program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again");
            }
        }
    }
}