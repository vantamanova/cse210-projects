using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = SquareNumber(number);

        DisplayResult(name, numberSquared);
    }
        
    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
        
    // Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
        
    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    // Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int numberSquared)
    {
        DisplayWelcome();
        Console.WriteLine($"{name}, the square of your number is {numberSquared}");
    }
        
}