public class EternalGoal : Goal {
    // Attributes
    // Constructors
    public EternalGoal(string name, string discription, int value) : base(name, discription, value) {
        
    }
    // Behaviors
    // Not done yet
    public override int RecordEvent() {
        Console.WriteLine();
        return 4;
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