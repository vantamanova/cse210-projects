class Menu 
{
    // Attributes
    // Constructors
    public Menu()
    {

    }
    // Behaviors

    // Used to display Main menu. Returnes int
    public int DisplayMenu()
    {
        List<string> menuOptions = new List<string>
        {
            "What do you want to do?",
            "   1. Practice",
            "   2. Load Progress",
            "   3. Save Progress",
            "   4. Quit",
        };
        WriteMultiLine(menuOptions);

        Console.Write("Please pick an option: ");
        int answer = int.Parse(Console.ReadLine());

        return answer;
    }

    // Used to display Operatios menu. Returnes int
    public int DisplayOperations()
    {
        List<string> menuOptions = new List<string>
        {
            "What do you want to work on?",
            "   1. Addition",
            "   2. Subtraction",
            "   3. Division",
            "   4. Multiplication",
            "   5. Comparison",
            "",
        };
        WriteMultiLine(menuOptions);

        Console.Write("Please pick an option: ");
        int answer = int.Parse(Console.ReadLine());

        return answer;
    }

    // Used to write multiple lines of text
    private static void WriteMultiLine(List<string> myList) {
        foreach (var line in myList)
        {
            Console.WriteLine(line);
        }
    }
}