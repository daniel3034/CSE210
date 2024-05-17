using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    protected void StartMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);
    }

    protected void EndMessage(string activityName)
    {
        Console.WriteLine("Great job!");
        Console.WriteLine($"You have completed the {activityName} activity for {duration} seconds.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Start();
}
