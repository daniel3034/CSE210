public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        StartMessage("Breathing Activity", 
                     "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int endTime = Environment.TickCount + duration * 1000;
        while (Environment.TickCount < endTime)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(4);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(4);
        }
        EndMessage("Breathing Activity");
    }
}
