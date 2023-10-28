public class Activity {
    // define attributes
    private string _activityName;
    private string _description;
    private int _duration;

    // Define Behaviors
    // Displaying the starting message.
    public void DisplayStartingMesssage() {
        Console.WriteLine($"Welcome to the {_activityName}.");
    }

    // Displaying the ending message
    public void DisplayEndingingMesssage() {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
    }
    // Pausing while showing a spinner
    public void SpinnerPause() {
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(10000);
        Console.WriteLine("I'm back!!");
    }

    // Pausing while showing a countdown timer
    public void TimerPause() {
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(5000);
        Console.WriteLine("I'm back!!");
    }

    // Constructor for Activity Class
    public Activity(string name, string description, int duration) {
        _activityName = name;
        _description = description;
        _duration = duration;
    }

    // Getters

    public string GetActivityName() {
        return _activityName;
    }

    public string GetDescription() {
        return _description;
    }

    public string GetDuration() {
        return _duration;
    }


}