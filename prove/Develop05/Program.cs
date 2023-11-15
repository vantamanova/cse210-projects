using System;

class Program
{
    static void Main(string[] args)
    {
        //int option = -1;
        while (true) {
            // Showing the menu
            Console.WriteLine("You have 0 points");
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
                

                Console.Write("What is amound of points? ");
                int value = int.Parse(Console.ReadLine());
                

                if (goalType == 1) {
                    SimpleGoal newgoal = new SimpleGoal(name, description, value);
                    // Checking display
                    newgoal.DisplayGoal();
                }
                if (goalType == 2) {
                    EternalGoal newgoal = new EternalGoal(name, description, value);
                    // Checking display
                    newgoal.DisplayGoal();
                }
                if (goalType == 3) {
                    Console.Write("What is a bonus amound? ");
                    int bonus = int.Parse(Console.ReadLine());

                    Console.Write("What is a plan amound? ");
                    int plan = int.Parse(Console.ReadLine());
                    ChecklistGoal newgoal = new ChecklistGoal(name, description, value, bonus, plan);
                    // Checking display
                    newgoal.DisplayGoal();
                }
                
            }
            if (option == 2) {
                break;
            }
            if (option == 3) {
                break;
            }
            if (option == 4) {
                break;
            }
            if (option == 5) {
                break;
            }
            if (option == 6) {
                break;
            }
        }
    }
}