public class Activity {
    // define attributes
    protected string _activityName;
    protected string _description;
    protected int _duration;
    private List<string> _animationStrings = new List<string>();


    public Activity () {

        // Adding characters to the list (Put it to the different part of the program)
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
    }


    // Define Behaviors
    // Displaying the starting message.
    public void DisplayStartingMesssage() {
        // start with a common starting message that provides the name of the activity,
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        // a description,
        Console.WriteLine(_description);
        Console.WriteLine();
        // and asks for and sets the duration of the activity in seconds.
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine(_duration);
    }

    // Displaying the ending message
    public void DisplayEndingingMesssage() {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
    }
    // Pausing while showing a spinner
    public void SpinnerPause() {
        foreach (string s in _animationStrings) {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }

    // Pausing while showing a countdown timer
    public void TimerPause() {
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(2000);
        Console.WriteLine("I'm back!!");
    }

    // Constructor for Activity Class
    /*public Activity(string name, string description, int duration) {
        _activityName = name;
        _description = description;
        _duration = duration;
    }*/

    // Getters

    public string GetActivityName() {
        return _activityName;
    }

    public string GetDescription() {
        return _description;
    }

    public int GetDuration() {
        return _duration;
    }


}