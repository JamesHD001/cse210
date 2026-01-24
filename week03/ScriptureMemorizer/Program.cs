// Exceeded requirements:
// Added a library of scriptures and randomly selects one at startup for the user, 
// different scriptures on each start up and making the scripture memorization more impactful.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Create a library of 5 scriptures (Bible & Book of Mormon)
        List<Scripture> library = new List<Scripture>();

        library.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        ));

        library.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life"
        ));

        library.Add(new Scripture(
            new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God"
        ));

        library.Add(new Scripture(
            new Reference("Ether", 12, 27),
            "My grace is sufficient for all men that humble themselves before me"
        ));

        library.Add(new Scripture(
            new Reference("Alma", 37, 6, 7),
            "By small and simple things are great things brought to pass"
        ));

        // Pick a random scripture
        Random rand = new Random();
        int index = rand.Next(library.Count);
        Scripture scripture = library[index];

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}
