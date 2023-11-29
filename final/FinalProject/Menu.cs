class Menu 
{
    // Attributes
    private string _date;
    private int _level;
    private string _userName;
    private int _progress;

    // Constructors
    public Menu(string name)
    {
        _userName = name;
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

    // Useed to create an assignment. Returns Operation object
    public Operation CreateAssignment(int operation)
    {
        if (operation == 1)
        {
            Addition assignment = new Addition();
            assignment.ShowDescription();
            return assignment;
        }
        if (operation == 2)
        {
            Subtraction assignment = new Subtraction();
            assignment.ShowDescription();
            return assignment;
        }
        if (operation == 3)
        {
            Division assignment = new Division();
            assignment.ShowDescription();
            return assignment;
        }
        if (operation == 4)
        {
            Multiplication assignment = new Multiplication();
            assignment.ShowDescription();
            return assignment;
        }
        else // Need to think on this
        {
            Comparison assignment = new Comparison();
            assignment.ShowDescription();
            return assignment;
        }  
    }

    public void RunAssignment(Operation assignment) // is there other way to do it?
    {
        // Need to create a loop here
        Console.Clear();
        int i = 0;
        while (i != 10)
        {
            int answer = assignment.GetAssignment();
            Console.WriteLine(assignment.CheckAssignment(answer));
            i += 1;
        }
        Console.WriteLine($"You got {assignment.GetScore()} points!"); // Need to put it to total game score? or not
    }

    // Used to save progress to a .txt file
    public void SaveProgressTxt(List<Operation> assigmentsList, string name) // done
    {
        Console.Write("Plaese enter the file name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName, false))
        {
            outputFile.WriteLine(name);
            foreach (Operation assignment in assigmentsList) {
                outputFile.WriteLine(assignment.GetStringRepresentation());
            }
        }
    }
    
    // Used to add the assignment to the list and avoid duplication
    public List<Operation> AddAssignment(List<Operation> assigmentsList, Operation assignment)
    {
        bool notInTheList = true;
        // Checking if this type of assignment already exist
        foreach (var element in assigmentsList)
            {
                if (element.GetName() == assignment.GetName())
                {
                    element.SetScore(element.GetScore() + assignment.GetScore());
                    notInTheList = false;
                    break;
                }
            }
        
        // If the type of assignment doesn't exist add it to the list
        if (notInTheList == true) 
        {
            assigmentsList.Add(assignment);
        }

        return assigmentsList;
    }

    // Used to load progress from .txt file
    public void LoadProgressTxt()
    {
        Console.Write("Plaese enter the file name: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Not finished");
    }
}