using System;

class Program
{
    static void Main(string[] args)
    {
        int progress = 0;
        Menu menu = new Menu();
        Console.Clear();
        Console.WriteLine("Welcome to Math Tytoring Program!");

        while (true)
        {
            int answer = menu.DisplayMenu();
            if (answer == 1)
            {
                int operation = menu.DisplayOperations();
            }
            else if (answer == 2)
            {
                menu.LoadProgressTxt();
            }
            else if (answer == 3)
            {
                menu.SaveProgressTxt();
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