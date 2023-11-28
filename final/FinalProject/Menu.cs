class Menu 
{
    // Attributes
    private string _date;
    private int _level;
    private string _userName;
    private int _progress;

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

        Console.WriteLine();
        Console.Write("Please pick an option: ");
        int answer = int.Parse(Console.ReadLine());

        return answer;
    }

    // Used to display Operatios menu. Returnes int
    public int DisplayOperations()
    {
        Console.Clear();
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
    private static void WriteMultiLine(List<string> myList)
    {
        foreach (var line in myList)
        {
            Console.WriteLine(line);
        }
    }

    // Used to create and run right type of assignment
    public void RunAssignment()
    {
        Console.WriteLine("Not finished");
    }

    // Used to save progress to a .txt file
    public void SaveProgressTxt()
    {
        Console.Write("Plaese enter the file name: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Not finished");
    }
    
    // Used to load progress from .txt file
    public void LoadProgressTxt()
    {
        Console.Write("Plaese enter the file name: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Not finished");
    }
}