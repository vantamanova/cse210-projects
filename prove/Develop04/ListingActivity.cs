public class ListingActivity : Activity {
    // Attributes
    private static List<string> _promptList = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    // Constructor

    public ListingActivity() {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    }
   

    //Behaviours

    public void RunListingActivity() {
        // start with a common starting message that provides the name of the activity,
        // a description, and asks for and sets the duration of the activity in seconds.
        DisplayStartingMesssage();
        // Then, it should tell the user to prepare to begin and pause for several seconds.
        // a spinner, a countdown timer, or periods being displayed to the screen.
        GetReady();
        // Prompt
        Console.WriteLine("List as many reasponses you can to the following prompt:");
        Console.WriteLine($" --- {GetPrompt()} --- ");
        Console.Write("You may start in: ");
        TimerPause(9);
        Console.WriteLine();

        // Listing part
        Listing();
        // Each activity should end with a common ending message that tells the user they have done a good job,
        // and pause
        // a spinner, a countdown timer, or periods being displayed to the screen.
        WellDone();
        // and then tell them the activity they have completed and the length of time
        // and pauses for several seconds before finishing
        DisplayEndingingMesssage();

    }

    
    private static string GetPrompt() {
        Random rnd = new Random();
        int numb = rnd.Next(0, _promptList.Count);
    
        return _promptList[numb];
    }

    private static int Listing() {
        int numberOfEntries = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime) {
            Console.Write("> ");
            Console.ReadLine();
            numberOfEntries += 1;
        }

        Console.WriteLine($"You listed {numberOfEntries} items!");
        return numberOfEntries;
    }
  
}