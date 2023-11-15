public class SimpleGoal : Goal {
    // Attributes
    private static bool _isComplete;
    // Constructors
    public SimpleGoal(string name, string discription, int value) : base(name, discription, value) {
        _isComplete = false;
    }
    // Behaviors
   // Not done
    public override int RecordEvent() {
        Console.WriteLine();
        return 4;
    }

    // Returnes the string according to _isComplete. Same code in two places
    public static string IsComplete() {
        if (_isComplete == true) {
            return "[X]";
        }
        else {
            return "[ ]";
        }
        
    }
    
    // Displays the Goal. Done
    public override void DisplayGoal() {
        Console.WriteLine($"{IsComplete()} {_name} ({_discription})");
    }
    public override void SaveGoals() {
        Console.WriteLine();
    }
    public override void LoadGoals() {
        Console.WriteLine();
    }
    
}