class Menu 
{
    // Attributes
    private string _date;
    private int _level; // Used in Operation Class no need for this to be here
    private string _userName;
    private int _progress; // Do I need it here?
    


    // Constructors
    public Menu(string name)
    {
        _userName = name;
    }
    
    
    // Behaviors

    // Used to display Main menu. Returns int
    public int DisplayMenu() 
    {
        List<string> menuOptions = new List<string>
        {
            "What do you want to do?",
            "   1. Practice",
            "   2. Load Progress",
            "   3. Save Progress",
            "   4. Show Progress",
            "   5. Quit",
        };
        WriteMultiLine(menuOptions);

        Console.WriteLine();
        Console.Write("Please pick an option: ");
        int answer = int.Parse(Console.ReadLine());

        return answer;
    }

    // Used to display Operatios menu. Returns int
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

    // Used to show progress on assignments
    public void ShowProgress(List<Operation> assigmentsList)
    {
        foreach (var element in assigmentsList)
        {
            Console.WriteLine($"{element.GetName()}. Score: {element.GetScore()}. Level: {element.GetLevel()}");
        }
    }
    
    // Used to write multiple lines of text
    private static void WriteMultiLine(List<string> myList)
    {
        foreach (var line in myList)
        {
            Console.WriteLine(line);
        }
    }

    // Used to create an assignment. Returns Operation object
    public Operation CreateAssignment(int operation)
    {
        // Getting duration of the assignment
        Console.Write("How long would you like to practice? (in seconds): ");
        int duration = int.Parse(Console.ReadLine());

        if (operation == 1)
        {
            Addition assignment = new Addition(duration);
            assignment.ShowDescription();
            return assignment;
        }
        if (operation == 2)
        {
            Subtraction assignment = new Subtraction(duration);
            assignment.ShowDescription();
            return assignment;
        }
        if (operation == 3)
        {
            Division assignment = new Division(duration);
            assignment.ShowDescription();
            return assignment;
        }
        if (operation == 4)
        {
            Multiplication assignment = new Multiplication(duration);
            assignment.ShowDescription();
            return assignment;
        }
        else // Need to think on this
        {
            Comparison assignment = new Comparison(duration);
            assignment.ShowDescription();
            return assignment;
        }  
    }

    // Keep showing assignments
    public void RunAssignment(Operation assignment) // is there other way to do it?
    {
        // Using loop keeps showing assignments according to duration picked by user 
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(assignment.GetDuration());

        while (DateTime.Now < endTime)
        {
            int answer = assignment.GetAssignment();
            Console.WriteLine(assignment.CheckAssignment(answer));
            
        }

        // Checks if they can Level Up
        Console.WriteLine($"You got {assignment.GetScore()} points on {assignment.GetName()} assignment!"); // Need to put it to total game score? or not
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
    public List<Operation> LoadProgressTxt() {
        List<Operation> operationsList = new List<Operation>();

        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _userName = lines[0];
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            if (parts[0] == "Addition") {
                Addition newAssignment = new Addition();
                newAssignment.LoadProgress(parts[1]);
                operationsList.Add(newAssignment);
            }
            if (parts[0] == "Subtraction") {
                Subtraction newAssignment = new Subtraction();
                newAssignment.LoadProgress(parts[1]);
                operationsList.Add(newAssignment);
            }
            if (parts[0] == "Division") {
                Division newAssignment = new Division();
                newAssignment.LoadProgress(parts[1]);
                operationsList.Add(newAssignment);
            }  
            if (parts[0] == "Multiplication") {
                Multiplication newAssignment = new Multiplication();
                newAssignment.LoadProgress(parts[1]);
                operationsList.Add(newAssignment);
            }
            if (parts[0] == "Comparison") {
                Comparison newAssignment = new Comparison();
                newAssignment.LoadProgress(parts[1]);
                operationsList.Add(newAssignment);
            }      
        }

        return operationsList;
    }

    // Used to get total score. DO I NEED IT
    public int GetTotalScore(int operation, List<Operation> assigmentsList)
    {
        string operationName = "";
        int totalScore = 0; 

        if (operation == 1)
        {
            operationName = "Addition";
        }
        if (operation == 2)
        {
            operationName = "Subtraction";
        }
        if (operation == 3)
        {
            operationName = "Division";
        }
        if (operation == 4)
        {
            operationName = "Multiplication";
        }
        if (operation == 5)
        {
            operationName = "Comparison";
        }

        foreach (var element in assigmentsList)
        {

            if (element.GetName() == operationName)
            {
                totalScore = element.GetScore();
                break;
            }  
        }

        Console.WriteLine($"Total Score on {operationName} assignment is {totalScore}");
        return totalScore;

    }
}