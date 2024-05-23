using System;
using System.Collections.Generic;
using System.IO;
abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string Serialize();
}

class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points, bool isCompleted = false) : base(name, points)
    {
        IsCompleted = isCompleted;
    }

    public override int RecordEvent()
    {
        IsCompleted = true;
        return Points;
    }

    public override string GetStatus()
    {
        return IsCompleted ? "[X] " + Name : "[ ] " + Name;
    }

    public override string Serialize()
    {
        return $"SimpleGoal,{Name},{Points},{IsCompleted}";
    }
}

class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetStatus()
    {
        return "[∞] " + Name;
    }

    public override string Serialize()
    {
        return $"EternalGoal,{Name},{Points}";
    }
}

class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints, int currentCount = 0, bool isCompleted = false)
        : base(name, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = currentCount;
        IsCompleted = isCompleted;
    }

    public override int RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                IsCompleted = true;
                return Points + BonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return IsCompleted ? $"[X] {Name} (Completed {CurrentCount}/{TargetCount})" : $"[ ] {Name} (Completed {CurrentCount}/{TargetCount})";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal,{Name},{Points},{CurrentCount},{TargetCount},{BonusPoints},{IsCompleted}";
    }
}
