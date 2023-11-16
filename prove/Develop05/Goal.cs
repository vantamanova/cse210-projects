public abstract class Goal {
    // Attributes
    protected string _name;
    protected string _discription;
    protected int _value; //Not sure if I need it here
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
    // How does static method shoul work in parent class?
    //public static abstract bool IsComplete(); 
    public abstract void DisplayGoal();
    public abstract string SaveGoals();
    public abstract void LoadGoals(string line);
    public void DisplayScore() {
        Console.WriteLine("Score");
    }
    public string GetName() {
        return _name;
    }
    




}