public class ListingActivity : Activity
{
    private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        StartMessage("Listing Activity", 
                     "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        PauseWithAnimation(3);
        int startTime = Environment.TickCount;
        int endTime = startTime + duration * 1000;
        int itemCount = 0;
        while (Environment.TickCount < endTime)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCount++;
        }
        Console.WriteLine($"You listed {itemCount} items.");
        EndMessage("Listing Activity");
    }
}
