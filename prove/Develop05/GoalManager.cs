public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        _score += goal.RecordEvent();
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.ToFileString());
            }
        }
        Console.WriteLine("Goals saved to file successfully.");
    }

    public void LoadFromFile(string file)
{
    if (File.Exists(file))
    {
        _goals.Clear();
        _score = 0; // Reiniciar el puntaje al cargar nuevos goals
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                string goalType = parts[0];
                Goal goal = null;

                switch (goalType)
                {
                    case "SimpleGoal":
                        goal = SimpleGoal.FromFileString(line);
                        break;
                    case "CheckListGoal":
                        goal = CheckListGoal.FromFileString(line);
                        break;
                    case "EternalGoal":
                        goal = EternalGoal.FromFileString(line);
                        break;
                }

                if (goal != null)
                {
                    _goals.Add(goal);
                    _score += goal.RecordEvent(); // Registrar el progreso en el puntaje
                }
            }
        }
        Console.WriteLine("Goals loaded from file successfully.");
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}
    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create a Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoalFromUserInput();
                    break;
                case "5":
                    RecordEventFromUserInput();
                    break;
                case "6":
                    Console.Write("Enter the file name to save goals: ");
                    string saveFile = Console.ReadLine();
                    SaveToFile(saveFile);
                    break;
                case "7":
                    Console.Write("Enter the file name to load goals: ");
                    string loadFile = Console.ReadLine();
                    LoadFromFile(loadFile);
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private void CreateGoalFromUserInput()
    {
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");

        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new CheckListGoal(name, description, points, target, bonus);
                break;
            case "3":
                goal = new EternalGoal(name, description, points);
                break;
            default:
                Console.WriteLine("Invalid goal type, returning to menu.");
                return;
        }

        CreateGoal(goal);
    }
private void RecordEventFromUserInput()
{
    Console.Write("Enter the name of the goal to record an event for: ");
    string name = Console.ReadLine();

    Goal goal = _goals.Find(g => g.Name == name);

    if (goal != null)
    {
        RecordEvent(goal);
        Console.WriteLine("Event recorded.");
    }
    else
    {
        Console.WriteLine("Goal not found.");
    }
}
}