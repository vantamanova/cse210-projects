using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"You name is {lastname}, {name} {lastname}");

    }
}