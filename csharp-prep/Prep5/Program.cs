using System;

class Program
{
    static void Main(string[] args)
    {
        welcome();

        string username = promptusername();

        int number = promptusernumber();

        int square = Squarenumber(number);

        Displayresult(username, square);
    }

    static void welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptusername()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int promptusernumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int Squarenumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void Displayresult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}