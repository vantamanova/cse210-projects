using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World000000!");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("Quit");
        Console.WriteLine("Select a choice from the menu: ");

        // testing functions:
        Activity activity = new Activity("Boo", "Booooooo", 20);
        activity.DisplayStartingMesssage();
        activity.DisplayEndingingMesssage();
        activity.SpinnerPause();
        activity.TimerPause();



        
    }
}