public class EternalGoal : Goal {
    // Attributes
    // Constructors
    public EternalGoal(string name, string discription, int value) : base(name, discription, value) {   
    }
    public EternalGoal() {}

    // Behaviors
    // Completes the goal. Returns the points
    public override int RecordEvent() {
        Console.WriteLine($"Congratulations! You have earned {_value} points");
        return _value;
    }
   
    // Displays the Goal
    public override void DisplayGoal() {
        Console.WriteLine($" [ ] {_name} ({_discription})");
    }
    
    // Returns the string to save the goal.
    public override string GetStringRepresentation() { 
        return ($"EternalGoal:{_name} | {_discription} | {_value}");
    }
    public override void LoadGoals(string line) {
        string[] parts = line.Split(" | ");
        _name = parts[0];
        _discription = parts[1];
        _value = int.Parse(parts[2]);

    }
}