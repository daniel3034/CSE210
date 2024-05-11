using System;
using System.Collections.Generic;
using System.Linq;

// Added a progress indicator, that indicates how many words are hidden. (In the scripture class)

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John 3:16");
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whoever believes in him should not perish but have everlasting life.");

        while (!scripture.AllWordsHidden())
        {
           scripture.Display();
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWord();
            }
 
        }
    }
}