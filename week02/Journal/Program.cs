using System;
using System.Collections.Generic;
using System.IO;

/// creativity:
/// - added a motivational message when saving the journal.
/// - added extra prompts beyond the required five.
/// - added entry count when displayed the journal.

Journal journal = new Journal();
PromptGenerator promptGenerator = new PromptGenerator();

int choice = 0;
while (choice != 5)
{
    Console.WriteLine();
    Console.WriteLine("journal menu:");
    Console.WriteLine("1. write");
    Console.WriteLine("2. display");
    Console.WriteLine("3. save");
    Console.WriteLine("4. load");
    Console.WriteLine("5. quit");
    Console.Write("choose an option: ");

    string input = Console.ReadLine();
    choice = int.Parse(input);

    if (choice == 1)
    {
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.Write("> ");

        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._promptText = prompt;
        newEntry._entryText = response;

        journal.AddEntry(newEntry);
    }
    else if (choice == 2)
    {
        Console.WriteLine();
        Console.WriteLine($" total entries: {journal._entries.Count}");
        journal.DisplayAll();
    }
    else if (choice == 3)
    {
        Console.Write("enter filename to save: ");
        string file = Console.ReadLine();

        journal.SaveToFile(file);
        Console.WriteLine("journal saved successfully! keep up the great work!");
        Console.WriteLine("Your future self appreciates the documentation effort!");
    }
    else if (choice == 4)
    {
        Console.Write("enter filename to load: ");
        string file = Console.ReadLine();

        journal.LoadFromFile(file);

        Console.WriteLine("journal loaded successfully! welcome back to your reflections!");
    }
    else if (choice == 5)
    {
        Console.WriteLine("Goodbye!");
    }
    else
    {
        Console.WriteLine("invalid choice, please try again.");
    }
}
