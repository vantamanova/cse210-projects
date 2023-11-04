public class ReflectingActivity : Activity {

    // Attributes
    private static List<string> _promptList = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    private static List<string> _questionsList = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructor
    public ReflectingActivity() {
        _activityName = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
  

    // Behaviors

    public void RunReflectingActivity() {
        // start with a common starting message that provides the name of the activity,
        // a description, and asks for and sets the duration of the activity in seconds.
        DisplayStartingMesssage();
        // Then, it should tell the user to prepare to begin and pause for several seconds.
        Console.Clear();
        Console.WriteLine("Get Ready...");
        // a spinner, a countdown timer, or periods being displayed to the screen.
        SpinnerPause();
        // Prompt
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetPrompt()} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        TimerPause();
        // Questions
        Console.Clear();
        Console.WriteLine();
        GetQuestions();

        // Each activity should end with a common ending message that tells the user they have done a good job,
        Console.WriteLine();
        Console.WriteLine("Good Job!");
        // and pause
        // a spinner, a countdown timer, or periods being displayed to the screen.
        SpinnerPause();
        // and then tell them the activity they have completed and the length of time
        DisplayEndingingMesssage();
        // and pauses for several seconds before finishing
        SpinnerPause();

    }

    private static string GetPrompt() {
        Random rnd = new Random();
        int numb = rnd.Next(0, _promptList.Count);
    
        return _promptList[numb];
    }

    private static void GetQuestions() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);


        foreach (string question in _questionsList) {
            if (DateTime.Now < endTime) {
                Console.Write($"> {question} ");
                SpinnerPause();
                Console.WriteLine();
            }
            else break; 
        }

    }

    

}