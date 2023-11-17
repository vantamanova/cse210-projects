public abstract class Goal {
    // Attributes
    protected string _name;
    protected string _discription;
    protected int _value; 
    protected int _points;

    // Constructors
    public Goal(string name, string discription, int value) {
        _name = name;
        _discription = discription;
        _value = value;
    }
    public Goal(){

    }

    // Behaviors
    public abstract int RecordEvent();
    public abstract void DisplayGoal();
    public abstract string SaveGoals();
    public abstract void LoadGoals(string line);
    public string GetName() {
        return _name;
    }
    




}