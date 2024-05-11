using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private readonly Reference reference;
    private readonly List<Word>words;
    private readonly Random random;
    public Scripture(Reference reference, string text)
    {
       this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
        random = new Random();  
    }

    public void Display()
    {
        if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }

        else 
        {
            Console.WriteLine(reference);
            int hiddenCount = words.Count(word => word._isHidden);
            int totalWords = words.Count;
            int visibleCount = totalWords - hiddenCount;
            Console.WriteLine($"Words hidden: {hiddenCount}/{totalWords}");
            foreach (Word word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("\n\nPress Enter to continue or type 'quit' to exit.");
        }
    }

    public void HideRandomWord()
    {
        var unhiddenWords = words.Where(word => !word._isHidden).ToList();
        if (unhiddenWords.Count > 0)
        {
            int index = random.Next(0, unhiddenWords.Count);
            unhiddenWords[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word._isHidden);
    }
}
    
