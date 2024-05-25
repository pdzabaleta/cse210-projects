public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            return Points + _bonus;
        }
        return Points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{Name} (Checklist Goal): {Description} - Points: {Points}, Target: {_target}, Bonus: {_bonus}, Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{Name} (Checklist Goal): {Description} - Points: {Points}, Target: {_target}, Bonus: {_bonus}, Completed: {_amountCompleted}/{_target}";
    }

    public override string ToFileString()
    {
        return $"CheckListGoal|{base.ToFileString()}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public static Goal FromFileString(string fileString)
    {
        var parts = fileString.Split('|');
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        int amountCompleted = int.Parse(parts[4]);
        int target = int.Parse(parts[5]);
        int bonus = int.Parse(parts[6]);

        var goal = new CheckListGoal(name, description, points, target, bonus)
        {
            _amountCompleted = amountCompleted
        };

        return goal;
    }
}