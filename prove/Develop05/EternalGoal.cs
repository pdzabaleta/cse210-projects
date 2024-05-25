public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{Name} (Eternal Goal): {Description} - Points: {Points}";
    }

    public override string ToFileString()
    {
        return $"EternalGoal|{base.ToFileString()}";
    }

    public static Goal FromFileString(string fileString)
    {
        var parts = fileString.Split('|');
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

        return new EternalGoal(name, description, points);
    }
}
