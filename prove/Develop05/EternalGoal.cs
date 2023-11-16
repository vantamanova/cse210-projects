public class EternalGoal : Goal {
    // Attributes
    // Constructors
    public EternalGoal(string name, string discription, int value) : base(name, discription, value) {   
    }

    // Behaviors
    // Completes the goal. Returnes the points
    public override int RecordEvent() {
        Console.WriteLine($"Congratulations! You have earned {_value} points");
        return _value;
    }
   
    // Displays the Goal
    public override void DisplayGoal() {
        Console.WriteLine($"[ ] {_name} ({_discription})");
    }
    
    // Returnes the string to save the goal. (Should change the name)
    public override string SaveGoals() {
        return ($"EternalGoal: | {_name} | {_discription} | {_value}");
    }
    public override void LoadGoals() {
        Console.WriteLine();
    }
}