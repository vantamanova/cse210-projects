public class Menu {
    //
    int _score;

    // Behaviors
    // Prints options for the main program menu and returns what option the user picked
    public int ShowMainMenu() {
        List<string> menu = new List<string> {
            "Menu option:",
            "     1. Create New Goal",
            "     2. List goals",
            "     3. Save Goals",
            "     4. Load Goals",
            "     5. Record Event",
            "     6. Quit",
        };

        WriteMultiLine(menu);
        
        Console.Write("Select a choice from menu: ");
        int option = int.Parse(Console.ReadLine());

        return option;
    }

    // 1. Prints types of goals user can create. Returns the goal type
    public int ShowGoalTypes() {
        List<string> goalTypes = new List<string> {
            "The types of goals are: ",
            "     1. Simple Goal",
            "     2. Eternal Goal",
            "     3. Checklist Goal",
            "     4. Negative Goal",
        };
        
        WriteMultiLine(goalTypes);

        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        return goalType;
    }

    // 1. Creates a goal according to goal type
    public Goal CreateGoal(int goalType) {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
                
        Console.Write("What is the amound of points associated with this goal? ");
        int value = int.Parse(Console.ReadLine());

        if (goalType == 1) {
            SimpleGoal newGoal = new SimpleGoal(name, description, value);
            return newGoal;
        }
        if (goalType == 2) {
            EternalGoal newGoal = new EternalGoal(name, description, value);
            return newGoal;
        }
        if (goalType == 3) {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int plan = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newGoal = new ChecklistGoal(name, description, value, bonus, plan);
            return newGoal; 
        }
        else {
            NegativeGoal newGoal = new NegativeGoal(name, description, value);
            return newGoal;
        }
    }

    // 2. Displays all goals
    public void ShowGoals(List<Goal> myGoals) {
        int i = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in myGoals) {
            Console.Write($"{i}.");
            goal.DisplayGoal();
            i += 1;
        }
    }

    // 3. Saves all goalt to .txt file
    public void SaveGoalsTxt(List<Goal> myGoals, int score) {
        Console.Write("Enter the name of the file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName, false))
        {
            outputFile.WriteLine(score);
            foreach (Goal goal in myGoals) {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    // 4. Loads all goals and the total score from .txt file
    public List<Goal> LoadGoalsTxt() {
        List<Goal> myGoals = new List<Goal>();

        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            if (parts[0] == "SimpleGoal") {
                SimpleGoal newGoal = new SimpleGoal();
                newGoal.LoadGoals(parts[1]);
                myGoals.Add(newGoal);
            }
            if (parts[0] == "EternalGoal") {
                EternalGoal newGoal = new EternalGoal();
                newGoal.LoadGoals(parts[1]);
                myGoals.Add(newGoal);
            }
            if (parts[0] == "ChecklistGoal") {
                ChecklistGoal newGoal = new ChecklistGoal();
                newGoal.LoadGoals(parts[1]);
                myGoals.Add(newGoal);
            }  
            if (parts[0] == "NegativeGoal") {
                NegativeGoal newGoal = new NegativeGoal();
                newGoal.LoadGoals(parts[1]);
                myGoals.Add(newGoal);
            }       
        }

        return myGoals;
    }

    // Returnes total score after loading it from the file (might be a better way to do it)
    public int GetScore() {
        return _score;
    }

    // 5. Prints the list of goals and completes the goal which user picks
    public int AccomplishGoal(List<Goal> myGoals, int score) {
        Console.WriteLine("The goals are: ");
        int i = 1;
        foreach (Goal goal in myGoals) {
            Console.Write($"{i}. ");
            Console.WriteLine(goal.GetName());
            i += 1;
        }
        Console.Write("Which goal did you accomplish? ");
        int goalNum = int.Parse(Console.ReadLine()); 
        int index = goalNum - 1;
        Console.WriteLine(index);
        score += myGoals[goalNum-1].RecordEvent();
        Console.WriteLine($"You now have {score} points!");
        
        return score;
    }

    private static void WriteMultiLine(List<string> myList) {
        foreach (var line in myList)
        {
            Console.WriteLine(line);
        }
    }
}