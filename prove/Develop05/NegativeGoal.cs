public class NegativeGoal : Goal {
    // Attributes
    // Constructors   
    public NegativeGoal(string name, string discription, int value) : base(name, discription, value) {
    }
    public NegativeGoal() {} 

    // Behaviors
    public override int RecordEvent() {
        Console.WriteLine($"You lost {_value} points");
        return _value * (-1);
    }
    public override void DisplayGoal() {
        Console.WriteLine($" [ ] {_name} ({_discription})");
    }
    public override string GetStringRepresentation() { 
        return ($"NegativeGoal:{_name} | {_discription} | {_value}");
    }
    public override void LoadGoals(string line) {
        string[] parts = line.Split(" | ");
        _name = parts[0];
        _discription = parts[1];
        _value = int.Parse(parts[2]);
    }
}