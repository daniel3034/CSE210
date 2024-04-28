using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = -1;
        int number = 0;

        while (guess != number)
        {
            Console.Write("What is the magic number? ");
            number = int.Parse(Console.ReadLine());

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number == guess)
            {
                Console.WriteLine("You guess it!");
            }
            else
            {
                Console.WriteLine("Lower");  
            }
        }
    }    
}