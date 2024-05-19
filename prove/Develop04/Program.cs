// Added counters for the different activites, so the user can know how many times the activity was completed when he quit the program.

using System;

public class Program
{
    private static int breathingActivityCount = 0;
    private static int reflectionActivityCount = 0;
    private static int listingActivityCount = 0;
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Program");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing Activity");
            Console.WriteLine("2. Start reflection Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice of the activity: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                BreathingActivity activity = new BreathingActivity(duration);
                activity.Start();
                breathingActivityCount++;
            }
            else if (choice == "2")
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                ReflectionActivity activity = new ReflectionActivity(duration);
                activity.Start();
                reflectionActivityCount++;
            }
            else if (choice == "3")
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                ListingActivity activity = new ListingActivity(duration);
                activity.Start();
                listingActivityCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting the program.");
                Console.WriteLine($"Breathing Activity was performed {breathingActivityCount} times.");
                Console.WriteLine($"Reflection Activity was performed {reflectionActivityCount} times.");
                Console.WriteLine($"Listing Activity was performed {listingActivityCount} times.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select again.");
            }
        }
    }
}
