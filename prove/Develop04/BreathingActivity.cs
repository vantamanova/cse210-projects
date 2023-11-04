public class BreathingActivity : Activity {
    // Attributes

    // Constructor for Breathing Class
    public BreathingActivity() {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    // Behaviors

    public void RunBreathingActivity() {
        // start with a common starting message that provides the name of the activity,
        // a description, and asks for and sets the duration of the activity in seconds.
        DisplayStartingMesssage();

        // Then, it should tell the user to prepare to begin and pause for several seconds.
        // a spinner, a countdown timer, or periods being displayed to the screen.
        GetReady();
        
        // Breathig part
        Breath();
        
        // Each activity should end with a common ending message that tells the user they have done a good job,
        // and pause
        // a spinner, a countdown timer, or periods being displayed to the screen.
        WellDone();
        // and then tell them the activity they have completed and the length of time
        // and pauses for several seconds before finishing
        DisplayEndingingMesssage();
    }

    private static void Breath() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime) {
            Console.WriteLine();
            Console.Write("Breath in...");
            TimerPause(4);
            Console.WriteLine();
            Console.Write("Breath out...");
            TimerPause(5);
            Console.WriteLine();
        }
    }
}