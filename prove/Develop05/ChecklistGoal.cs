public class ChecklistGoal : Goal {
    // Attributes
    private static bool _isComplete;
    private int _plan;
    private int _result;
    private int _bonusAmound;

    // Constructors
    public ChecklistGoal(string name, string discription, int value, int bonus, int plan) : base(name, discription, value) {
        _isComplete = false;
        _bonusAmound = bonus;
        _plan = plan;
        _result = 0;
    }
    // Behaviors
   
    // Not done
    public override int RecordEvent() {
        Console.WriteLine();
        return 4;
    }
    
    // Returnes the string for display method. Same come in two places.
    public static string IsComplete() {
        if (_isComplete == true) {
            return "[X]";
        }
        else {
            return "[ ]";
        }
        
    }
    // Displays the goal. Done
    public override void DisplayGoal() {
        Console.WriteLine($"{IsComplete()} {_name} ({_discription}) - Currently Completed {_result}/{_plan}");
    }
    public override void SaveGoals() {
        Console.WriteLine();
    }
    public override void LoadGoals() {
        Console.WriteLine();
    }
    
}