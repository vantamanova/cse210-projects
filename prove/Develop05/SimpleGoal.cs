public class SimpleGoal : Goal {
    // Attributes
    private static bool _isComplete;
    // Constructors
    public SimpleGoal(string name, string discription, int value) : base(name, discription, value) {
        _isComplete = false;
    }
    // Behaviors
   // Completes the goal. Incharge of checking if the the Goal is complete. Returnes the points
    public override int RecordEvent() {
        Console.WriteLine($"Congratulations! You have earned {_value} points");
        _isComplete = true;
        return _value;
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
    
    // Returnes the string to save the goal. (Should change the name)
    public override string SaveGoals() {
        //string line = ($"SimpleGoal: | {_name} | {_discription} | {_value} | {_isComplete}");
        return ($"SimpleGoal: | {_name} | {_discription} | {_value} | {_isComplete}");
    }
    public override void LoadGoals() {
        Console.WriteLine();
    }
    
}