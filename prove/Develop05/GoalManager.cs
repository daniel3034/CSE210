class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;
    private LevelingSystem levelingSystem = new LevelingSystem();

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            int pointsEarned = goals[goalIndex].RecordEvent();
            totalScore += pointsEarned;
            levelingSystem.AddExperience(pointsEarned);
        }
    }

    public void ShowGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(totalScore);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
    }

    public void Load(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                totalScore = int.Parse(reader.ReadLine());
                goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);

                    Goal goal = null;
                    if (type == nameof(SimpleGoal))
                    {
                        bool isCompleted = bool.Parse(parts[3]);
                        goal = new SimpleGoal(name, points, isCompleted);
                    }
                    else if (type == nameof(EternalGoal))
                    {
                        goal = new EternalGoal(name, points);
                    }
                    else if (type == nameof(ChecklistGoal))
                    {
                        int currentCount = int.Parse(parts[3]);
                        int targetCount = int.Parse(parts[4]);
                        int bonusPoints = int.Parse(parts[5]);
                        bool isCompleted = bool.Parse(parts[6]);
                        goal = new ChecklistGoal(name, points, targetCount, bonusPoints, currentCount, isCompleted);
                    }

                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                }
            }
        }
    }
}
