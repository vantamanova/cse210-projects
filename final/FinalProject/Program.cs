using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        Console.Write("Please enter your name: ");
        string _name = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"Welcome to Math Tutoring Program, {_name}!");

        // Creates the Menu object and List to store all work
        Menu menu = new Menu(_name);
        Animation animation = new Animation();
        List<Operation> assigmentsList = new List<Operation>();

        while (true)
        {
            Console.WriteLine();
            int answer = menu.DisplayMenu();

            // Practice option
            if (answer == 1)
            {
                int operation = menu.DisplayOperations();
                int totalScore = menu.GetTotalScore(operation, assigmentsList); // Geting total points on the particular type of assignment
                Operation assignment = menu.CreateAssignment(operation, totalScore); // Gets the right type of assignment from the user to pass it as a parameter
                Console.Clear();
                assignment.ShowDescription();

                animation.GetReadyAnimation();
                menu.RunAssignment(assignment);
                menu.AddAssignment(assigmentsList, assignment); // Adds assignment to the list of Operation objects to store information
            }

            // Load file option
            else if (answer == 2)
            {
                assigmentsList = menu.LoadProgressTxt();
            }

            // Save file option
            else if (answer == 3)
            {
                menu.SaveProgressTxt(assigmentsList, _name);
            }
            
            // Show progress option
            else if (answer == 4)
            {
                Console.WriteLine();
                menu.ShowProgress(assigmentsList);
            }

            // Quit
            else if (answer == 5)
            {
                break;
            }

            else
            {
                Console.WriteLine("Something went wrong. Try again");
            }
        }
        Console.WriteLine($"The practice is over. See you next time, {_name}");
    }
}