using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John 3:16");
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

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