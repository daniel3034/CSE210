using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        bool exit = false;

        do
        {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (!exit);
    }

    static void WriteNewEntry()
    {
        journal.WriteNewEntry();
    }

    static void DisplayJournal()
    {
        journal.DisplayJournal();
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        journal.LoadFromFile(filename);
    }
}


