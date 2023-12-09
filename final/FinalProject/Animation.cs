class Animation
{
    // Attributes
    private static List<string> _animationStrings = new List<string> {"|", "/", "-", "\\", "|", "-", "\\", "|", "/", "-", "\\"};
    // Constructors

    public Animation()
    {

    }


    // Behaviors
     public void GetReadyAnimation() // Used befor assignmemt starts
    {
        Console.Write("Get Ready...");
        SpinnerPause();

        Console.Clear();
        Console.Write("Assignments starts in ");
        TimerAnimation(5); // Countdawn 5.. 4.. 3.. 2.. 1..
    }

    protected static void SpinnerPause() {
        foreach (string s in _animationStrings) {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    
    public static void TimerAnimation(int numb) {

        while (numb >= 0) {
            Console.Write(numb);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            numb -= 1;
        }
    }

}