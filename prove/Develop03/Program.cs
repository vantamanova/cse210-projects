using System;
using System.Diagnostics.Contracts;

/// <summary>
/// To excide requirements was done the following:
/// randomly selected only those words that are not already hidden
/// </summary>

class Program
{
    static void Main(string[] args)
    {

        // Gets the Scripture element
        Scripture scripture = new Scripture();
        Console.Clear();
        
        scripture.CreateList();
        scripture.ShowScripture();

        // Variable to store the answer
        string click = "";

        while (scripture.GetStatus() == false) {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            click = Console.ReadLine();

            scripture.HideWords();
            scripture.HideWords();
            scripture.HideWords();

            scripture.GetRenderedText();
            Console.Clear();
            scripture.ShowScripture();

            scripture.GetStatus();
        }
       
        Console.Clear();
    }
}