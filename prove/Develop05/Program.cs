using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> myGoals = new List<Goal>();
        int score = 0;

        while (true) {
            // Showing the menu
            Console.WriteLine($"You have {score} points");
            Console.WriteLine();
            Console.WriteLine("Menu option:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a chice from menu: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1) {
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("     1. Simple Goal");
                Console.WriteLine("     2. Eternal Goal");
                Console.WriteLine("     3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());
                
                // Creating the goal
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                

                Console.Write("What is the amound of points associated with this goal? ");
                int value = int.Parse(Console.ReadLine());
                

                if (goalType == 1) {
                    SimpleGoal newGoal = new SimpleGoal(name, description, value);
                    // Checking display
                    newGoal.DisplayGoal();
                    myGoals.Add(newGoal);
                }
                if (goalType == 2) {
                    EternalGoal newGoal = new EternalGoal(name, description, value);
                    // Checking display
                    newGoal.DisplayGoal();
                    myGoals.Add(newGoal);
                }
                if (goalType == 3) {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int plan = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal newGoal = new ChecklistGoal(name, description, value, bonus, plan);
                    // Checking display
                    newGoal.DisplayGoal();
                    myGoals.Add(newGoal);
                }
                
                
            }
            if (option == 2) {
                // Displaying goals using loop
                int i = 1;
                foreach (Goal goal in myGoals) {
                    Console.Write($"{i}.");
                    goal.DisplayGoal();
                    i += 1;
                }
            }
            if (option == 3) {
                // Getting the filename from the user
                Console.Write("Enter the name of the file: ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName, false))
                {
                    outputFile.WriteLine(score);
                    foreach (Goal goal in myGoals) {
                        outputFile.WriteLine(goal.SaveGoals());
                    }
                }
                Console.WriteLine("The file has been saved.");

            }
            if (option == 4) {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                lines = lines.Skip(1).ToArray();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(" | ");

                    if (parts[0] == "SimpleGoal:") {
                        SimpleGoal newGoal = new SimpleGoal();
                        newGoal.LoadGoals(line); // repitation!!!!
                        myGoals.Add(newGoal);
                    }
                    if (parts[0] == "EternalGoal:") {
                        EternalGoal newGoal = new EternalGoal();
                        newGoal.LoadGoals(line);
                        myGoals.Add(newGoal);
                    }
                    if (parts[0] == "ChecklistGoal:") {
                        ChecklistGoal newGoal = new ChecklistGoal();
                        newGoal.LoadGoals(line);
                        myGoals.Add(newGoal);
                    }
                    
                }
                Console.WriteLine("The file has been downloaded.");
                
            }
            if (option == 5) {
                Console.WriteLine("The goals are: ");
                int i = 1;
                foreach (Goal goal in myGoals) {
                    Console.Write($"{i}. ");
                    Console.WriteLine(goal.GetName());
                    i += 1;
                }
                Console.Write("Which goal did you accomplish? ");
                int goalNum = int.Parse(Console.ReadLine()); 
                score += myGoals[goalNum-1].RecordEvent();
            }
            if (option == 6) {
                break;
            }
        }
    }
}