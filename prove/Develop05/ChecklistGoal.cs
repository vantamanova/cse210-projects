public class ChecklistGoal : Goal {
    // Attributes
    private static bool _isComplete;
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
    // Behaviors
   
    // Completes a goal. Incharge of checking if the the Goal is complete. Returnes the points
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
    
    // Returnes the string for display method. Same come in two places.
    public static string IsComplete() {
        if (_isComplete == true) {
            return "[X]";
        }
        else {
            return "[ ]";
        }
        
    }
    // Displays the goal. Done
    public override void DisplayGoal() {
        Console.WriteLine($"{IsComplete()} {_name} ({_discription}) -- Currently completed: {_result}/{_plan}");
    }
    public override string SaveGoals() {
        return ($"ChecklistGoal: | {_name} | {_discription} | {_value} | {_bonusAmound} | {_plan} | {_result}"); // Shoul change the line
    }
    public override void LoadGoals() {
        Console.WriteLine();
    }
    
}