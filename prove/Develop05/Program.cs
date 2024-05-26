// Added a leveling system.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal(goalManager);
                    break;
                case "2":
                    RecordEvent(goalManager);
                    break;
                case "3":
                    goalManager.ShowGoals();
                    break;
                case "4":
                    goalManager.ShowScore();
                    break;
                case "5":
                    SaveGoals(goalManager);
                    break;
                case "6":
                    LoadGoals(goalManager);
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void AddGoal(GoalManager goalManager)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (goalType)
        {
            case "1":
                goal = new SimpleGoal(name, points);
                break;
            case "2":
                goal = new EternalGoal(name, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        if (goal != null)
        {
            goalManager.AddGoal(goal);
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        goalManager.ShowGoals();
        Console.Write("Enter goal number to record event: ");
        int goalNumber = int.Parse(Console.ReadLine());
        goalManager.RecordEvent(goalNumber - 1);
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        goalManager.Save(filename);
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        goalManager.Load(filename);
    }

    static void Levels(string[] args)
    {
        LevelingSystem levelingSystem = new LevelingSystem();
    }
}
