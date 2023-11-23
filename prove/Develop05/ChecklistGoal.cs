public class ChecklistGoal : Goal {
    // Attributes
    private bool _isComplete; // Can't be static
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
    public ChecklistGoal() {}
    // Behaviors
   
    // Completes a goal. In charge of checking if the the Goal is complete. Returns the points
    public override int RecordEvent() {
        
        Console.WriteLine($"Congratulations! You have earned {_value} points");
        _result += 1;

        if (_result == _plan) {
        _isComplete = true;
        Console.WriteLine($"The bonus amound is {_bonusAmound}.");
        return (_value + _bonusAmound);
        }
        else return _value;
    }
    
    // Returns the string for display method. Same come in two places.
    public static string IsComplete(bool isComplete) {
        if (isComplete == true) {
            return "[X]";
        }
        else {
            return "[ ]";
        }
        
    }
    // Displays the goal.
    public override void DisplayGoal() {
        Console.WriteLine($" {IsComplete(_isComplete)} {_name} ({_discription}) -- Currently completed: {_result}/{_plan}");
    }
    
    public override string GetStringRepresentation() {
        return ($"ChecklistGoal:{_name} | {_discription} | {_value} | {_bonusAmound} | {_plan} | {_result}");
    }
    public override void LoadGoals(string line) {
        string[] parts = line.Split(" | ");
        _name = parts[0];
        _discription = parts[1];
        _value = int.Parse(parts[2]);
        _bonusAmound = int.Parse(parts[3]);
        _plan = int.Parse(parts[4]);
        _result = int.Parse(parts[5]);

        if (_plan == _result) {
            _isComplete = true;
        }
        else {
            _isComplete = false;
        }
    }
    
}