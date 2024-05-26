class LevelingSystem
{
    private int level;
    private int experience;
    private int[] levelThresholds; 

    public LevelingSystem()
    {
        level = 1;
        experience = 0;
        levelThresholds = new int[] { 1, 2, 4, 8, 16, 32};
    }

    public void AddExperience(int points)
    {
        experience += points;
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {

        if (level < levelThresholds.Length && experience >= levelThresholds[level - 1])
        {
            level++;
            Console.WriteLine($"Congratulations! You've reached level {level}!");
        }
    }

}


