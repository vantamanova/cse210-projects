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
    // Behaviors
    public abstract int RecordEvent();
    //public static abstract bool IsComplete();
    public abstract void DisplayGoal();
    public abstract void SaveGoals();
    public abstract void LoadGoals();
    public void DisplayScore() {
        Console.WriteLine("Score");
    }
    




}