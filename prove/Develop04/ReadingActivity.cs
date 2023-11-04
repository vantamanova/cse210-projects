public class ReadingActivity : Activity {
    // Attributes
    private static List<string> _quotesList = new List<string> {
        @"“The body benefits from movement, and the mind benefits from stillness.”
– Sakyong Mipham",
        @"“Educating the mind without educating the heart is no education at all.”
– Aristotle",
        @"“When you focus on the good, the good gets better.”
– Abraham Hicks",
        @"“Your calm mind is the ultimate weapon against your challenges. So relax.”
– Bryant McGill",
        @"“The still waters of a lake reflect the beauty around it.
When the mind is still, the beauty of the self is reflected.”
– Vanda Scaravelli",
        @"“Just when you feel you have no time to relax,
know this is the moment you most need to relax.”
– Matt Haig",
        @"“The mind is like water. When it is turbulent, it is difficult to see.
When it is calm, everything becomes clear.”
– Prasad Mahes",
        @"“For what it is worth, it is never too late to be whoever you want to be.
I hope you live a life you are proud of, and if you find you are not,
I hope you have the strength to start over.”
– F. Scott Fitzgerald",
        @"“Mindfulness helps us to live in harmony with our thoughts, words, and actions.”
– Amit Ray",
        @"“Mindfulness meditation does not change life.
Life remains as fragile and unpredictable as ever.
Meditation changes the heart's capacity to accept life as it is.”
– Sylvia Boorstein",
    };

    // Constructor
    public ReadingActivity() {
        _activityName = "Reading Activity";
        _description = "This activity will help you to learn more about mindfulness benefits and best practises.";

    }

    // Behaviors
    public void RunReadingActivity() {
        DisplayStartingMesssage();
        GetReady();
        DisplayQuote();
        WellDone();
        DisplayEndingingMesssage();
    }

    private static string GetQuote() {
        Random rnd = new Random();
        int numb = rnd.Next(0, _quotesList.Count);

        return _quotesList[numb];
    }

    private static void DisplayQuote() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime) {
            Console.WriteLine();
            Console.Write("Press enter to generate the quote ");
            Console.ReadLine();

            string quote = GetQuote();
            for (int i = 0; i < quote.Length; i++) {
                Console.Write(quote[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
    }
}