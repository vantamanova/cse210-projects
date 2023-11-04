public class BreathingActivity : Activity {
    // Attributes

    // Constructor for Breathing Class
    public BreathingActivity() {
        Console.WriteLine("");
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    // Behaviors

    public void RunBreathingActivity() {
        DisplayStartingMesssage();

        // Then, it should tell the user to prepare to begin and pause for several seconds.
        Console.WriteLine("Get Ready...");
        // a spinner, a countdown timer, or periods being displayed to the screen.
        SpinnerPause();
        Console.Clear();
        // Breathig part
        Breath();
        
        // Each activity should end with a common ending message that tells the user they have done a good job,
        Console.WriteLine("Good Job!");
        // and pause
        // a spinner, a countdown timer, or periods being displayed to the screen.
        SpinnerPause();
        // and then tell them the activity they have completed and the length of time
        DisplayEndingingMesssage();
        // and pauses for several seconds before finishing
        Thread.Sleep(2000);
    }

public static void Breath() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime) {
            Console.Write("Breath in...");
            TimerPause();
            Console.WriteLine();
            Console.Write("Breath out...");
            TimerPause();
            Console.WriteLine();
            Console.WriteLine();
        }
}
}