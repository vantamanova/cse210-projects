using System;

/// <summary>
/// The following was done to exceed requirements:
/// - Added another kind of activity (Reading Activity)
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        // Menu
        int answer = -1;

        while (true) {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Start reading activity");
            Console.WriteLine("     5. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1) {
                Console.Clear();
                BreathingActivity activity1 = new BreathingActivity();
                activity1.RunBreathingActivity();
            }
            else if (answer == 2) {
                Console.Clear();
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.RunReflectingActivity();
            }
            else if (answer == 3) {
                Console.Clear();
                ListingActivity activity3 = new ListingActivity();
                activity3.RunListingActivity();
            }
            else if (answer == 4) {
                Console.Clear();
                ReadingActivity activity4 = new ReadingActivity();
                activity4.RunReadingActivity();

            }
            else if (answer == 5) {
                break;
            }
            else {
                Console.WriteLine("Please, pick an option from menu");
                Thread.Sleep(2000);
                continue;
            }
        }
    }
}