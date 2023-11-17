public class SimpleGoal : Goal {
    // Attributes
    private bool _isComplete; // Can't be static
    // Constructors
    public SimpleGoal(string name, string discription, int value) : base(name, discription, value) {
        _isComplete = false;
    }
    public SimpleGoal() {}

    // Behaviors
   // Completes the goal. In charge of checking if the Goal is complete. Returns the points
    public override int RecordEvent() {
        Console.WriteLine($"Congratulations! You have earned {_value} points");
        _isComplete = true;
        return _value;
    }

    // Returns the string according to _isComplete. Same code in two places
    public static string IsComplete(bool isComplete) {
        if (isComplete == true) {
            return "[X]";
        }
        else {
            return "[ ]";
        }  
    }
    
    // Displays the Goal. Done
    public override void DisplayGoal() {
        Console.WriteLine($"{IsComplete(_isComplete)} {_name} ({_discription})");
    }
    
    // Returns the string to save the goal. (Should change the name)
    public override string SaveGoals() {
        return ($"SimpleGoal: | {_name} | {_discription} | {_value} | {_isComplete}");
    }
    
    // Loads information from the file
    public override void LoadGoals(string line) {
        string[] parts = line.Split(" | ");
        _name = parts[1];
        _discription = parts[2];
        _value = int.Parse(parts[3]);

        if (parts[4] == "False") {
            _isComplete = false;
        }
        if (parts[4] == "True") {
            _isComplete = true;
        }
    }
    
}