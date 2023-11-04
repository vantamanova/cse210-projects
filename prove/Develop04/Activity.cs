public class Activity {
    // Attributes
    protected string _activityName;
    protected string _description;
    protected static int _duration;
    private static List<string> _animationStrings = new List<string> {"|", "/", "-", "\\", "|", "-", "\\", "|", "/", "-", "\\"};


    // Behaviors
    protected void DisplayStartingMesssage() {
        // start with a common starting message that provides the name of the activity,
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        // a description,
        Console.WriteLine(_description);
        Console.WriteLine();
        // and asks for and sets the duration of the activity in seconds.
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    // Displaying the ending message
    protected void DisplayEndingingMesssage() {
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        SpinnerPause();
    }
    // Pausing while showing a spinner
    protected static void SpinnerPause() {
        foreach (string s in _animationStrings) {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    // Pausing while showing a countdown timer
    protected static void TimerPause(int numb) {

        while (numb >= 0) {
            Console.Write(numb);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            numb -= 1;
        }
    }

    protected static void GetReady() {
        // Then, it should tell the user to prepare to begin and pause for several seconds.
        Console.Clear();
        Console.WriteLine("Get Ready...");
        // a spinner, a countdown timer, or periods being displayed to the screen.
        SpinnerPause();
    }

    protected static void WellDone() {
        // Each activity should end with a common ending message that tells the user they have done a good job,
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        // and pause
        // a spinner, a countdown timer, or periods being displayed to the screen.
        SpinnerPause();
    }    
}