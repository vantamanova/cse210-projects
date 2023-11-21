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
        if (_isComplete == false) {
            Console.WriteLine($"Congratulations! You have earned {_value} points");
            _isComplete = true;
            return _value;
        }
        else {
            Console.WriteLine("This goal has been completed already");
            return 0;
        }
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
    
    // Displays the Goal.
    public override void DisplayGoal() {
        Console.WriteLine($" {IsComplete(_isComplete)} {_name} ({_discription})");
    }
    
    // Returns the string to save the goal. 
    public override string GetStringRepresentation() { 
        return ($"SimpleGoal:{_name} | {_discription} | {_value} | {_isComplete}");
    }
    
    // Loads information from the file
    public override void LoadGoals(string line) {
        string[] parts = line.Split(" | ");
        _name = parts[0];
        _discription = parts[1];
        _value = int.Parse(parts[2]);

        if (parts[3] == "False") {
            _isComplete = false;
        }
        if (parts[3] == "True") {
            _isComplete = true;
        }
    }
    
}