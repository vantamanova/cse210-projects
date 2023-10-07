using System;
using System.CodeDom.Compiler;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Creates needed objects
        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal(); 
        
        // Displays the greeting
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following options:");


        // Shows the menu with options to a consol
        int menuNum = -1;
        while (menuNum != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.Write("What would you like to do? > ");

            // Stores user's input to a variable and converses it into int
            string input = Console.ReadLine();
            menuNum = int.Parse(input);

            // Depending on user's input does the following:
            // Creates a new Entry obgect
            if (menuNum == 1) 
            {
                // Generates the prompt
                string generatedPrompt = prompt.GeneratePrompt();
                
                // Creates new Entry object
                Entry entry = new Entry();
                entry.NewEntry(generatedPrompt);

                // Adds the entry to a Journal
                journal._entryJournal = entry;
                journal.AddEntry(); 
                
            }
            else if (menuNum == 2)
            {
                // Displays all entries in the journal
                journal.DisplayJournal();
            }
            else if (menuNum == 3)
            {
                // Loads the Journal from the file. Prompts user for a file name
                Console.Write("Please enter the file name: > ");
                journal._fileName = Console.ReadLine();
                journal.LoadFromFile();
            }
            else if (menuNum == 4)
            {
                // Saves the list of all enrties to a file. Prompts the user for a file name 
                Console.Write("Please enter the file name: > ");
                journal._fileName = Console.ReadLine();
                journal.SaveToFile();
            }
        }
    }
}