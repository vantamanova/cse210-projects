using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "yes";

        while (again == "yes")
        {
            //asking the user for the magic number
            //Console.Write("What is the magic number? ");
            //int number = int.Parse(Console.ReadLine());

            //generate a random number from 1 to 100
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            // Ask the user for a guess.
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            
            //tracker of guesses the user has made
            int tracker = 1;

            // Add a loop
            while (guess != number)
            {
                // determine if the user needs to guess higher or lower next time,
                // or tell them if they guessed it.
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    tracker++;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    tracker++;
                }
            }
            //Output
            Console.WriteLine($"You guessed it! It took you {tracker} guesses");

            //Play again option
            Console.WriteLine();
            Console.Write("Do you want to play again? yes/no ");
            again = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Thank you for playing!");
    }
}