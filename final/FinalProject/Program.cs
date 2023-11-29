using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Math Tytoring Program!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        // Creates the Menu object and List to store all work
        Menu menu = new Menu(name);
        List<Operation> assigmentsList = new List<Operation>();

        while (true)
        {
            int answer = menu.DisplayMenu();
            // Practice option
            if (answer == 1)
            {
                int operation = menu.DisplayOperations();
                Operation assignment = menu.CreateAssignment(operation); // Gets the right type of assignment from the user to pass it as a parameter

                menu.RunAssignment(assignment);
                menu.AddAssignment(assigmentsList, assignment);
            }
            // Load file option
            else if (answer == 2)
            {
                menu.LoadProgressTxt();
            }
            // Save file option
            else if (answer == 3)
            {
                menu.SaveProgressTxt(assigmentsList, name);
            }
            else if (answer == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Something went wrong. Try again");
            }
        }
    }
}