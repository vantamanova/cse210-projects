using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> myGoals = new List<Goal>();
        int score = 0;
        Menu menu = new Menu();

        while (true) {
            // Shows the menu
            Console.WriteLine($"You have {score} points");
            int option = menu.ShowMainMenu(); // Shows menu and returns the users input. 

            // New Goal option
            if (option == 1) {
                int goalType = menu.ShowGoalTypes(); // Shows goal types and returns users input.
                myGoals.Add(menu.CreateGoal(goalType));   
            }
            // Display Goals option
            if (option == 2) {
                menu.ShowGoals(myGoals);
            }
            // Save goals option
            if (option == 3) {
                menu.SaveGoalsTxt(myGoals, score);
                Console.WriteLine("The file has been saved.");
            }
            // Load goals option
            if (option == 4) {
                myGoals = menu.LoadGoalsTxt();
                score = menu.GetScore();
                Console.WriteLine("The file has been downloaded."); 
            }
            // Record event option
            if (option == 5) {
                score = menu.AccomplishGoal(myGoals, score); // Records Event and returns new score
            }
            if (option == 6) {
                break;
            }
        }
    }
}