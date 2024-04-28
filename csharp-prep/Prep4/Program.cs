using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   

        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)   
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        
        // Part 2
    
        Console.WriteLine($"The Sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        // Part 3

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max number is: {max}");
    }
}