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
    public override void SaveGoals() {
        Console.WriteLine();
    }
    public override void LoadGoals() {
        Console.WriteLine();
    }
}