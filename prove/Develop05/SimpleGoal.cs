public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return Points;
    }
   
    public override bool IsComplete()
    {
        return _isComplete;
    }
  
    public override string GetStringRepresentation()
    {
        return $"{Name} (Simple Goal): {Description} - Points: {Points}, Completed: {_isComplete}";
    }

    public override string ToFileString()
    {
        return $"SimpleGoal|{base.ToFileString()}|{_isComplete}";
    }

    public static Goal FromFileString(string fileString)
    {
        var parts = fileString.Split('|');
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        bool isComplete = bool.Parse(parts[4]);

        var goal = new SimpleGoal(name, description, points)
        {
            _isComplete = isComplete
        };

        return goal;
    }
}