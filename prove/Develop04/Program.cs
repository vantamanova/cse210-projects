using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("Quit");
        Console.WriteLine("Select a choice from the menu: ");

        // testing classes BreathingActivity:
        BreathingActivity activity2 = new BreathingActivity();
        activity2.RunBreathingActivity();



        
    }
}