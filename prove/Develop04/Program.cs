using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu
        int answer = -1;

        while (answer != 4) {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1) {
                Console.Clear();
                BreathingActivity activity2 = new BreathingActivity();
                activity2.RunBreathingActivity();
            }
            if (answer == 2) {
                Console.Clear();
                ReflectingActivity activity3 = new ReflectingActivity();
                activity3.RunReflectingActivity();
            }
            if (answer == 3) {
                Console.Clear();
                Console.WriteLine();
            }

            Console.Clear();
        }

        
        



        
    }
}