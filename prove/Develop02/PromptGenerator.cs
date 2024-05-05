using System;
using System.Collections.Generic;

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void WriteNewEntry()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random rnd = new Random();
        int index = rnd.Next(prompts.Length);
        string prompt = prompts[index];

        Console.WriteLine("Prompt: " + prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entries.Add(new JournalEntry { Prompt = prompt, Response = response, Date = DateTime.Now.ToString() });
        Console.WriteLine("Entry added successfully.");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry.Date} - {entry.Prompt}: {entry.Response}");
        }
    }

     public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                sw.WriteLine($"\"{entry.Date}\",\"{entry.Prompt.Replace("\"", "\"\"")}\",\"{entry.Response.Replace("\"", "\"\"")}\"");
            }
        }

        Console.WriteLine("Journal saved to file successfully.");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = SplitCsvLine(line);

                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    entries.Add(new JournalEntry { Date = date, Prompt = prompt, Response = response });
                }
            }

            Console.WriteLine("Journal loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    private static string[] SplitCsvLine(string line)
    {
        List<string> values = new List<string>();
        string value = "";

        bool inQuote = false;
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == '"')
            {
                inQuote = !inQuote;
            }
            else if (line[i] == ',' && !inQuote)
            {
                values.Add(value);
                value = "";
            }
            else
            {
                value += line[i];
            }
        }

        values.Add(value);
        return values.ToArray();
    }
}