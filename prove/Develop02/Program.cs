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
        // Create needed obgects
        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal(); 
        
        // Display the greeting
        Console.WriteLine("Welcome to the Jornal Program!");
        Console.WriteLine("Please select on of the following choises:");


        // Shows menu with optiont to a consol prompti
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

            // Storing users input to a variable and converse it into int
            string input = Console.ReadLine();
            menuNum = int.Parse(input);

            // According users input doing the following:
            // Create a new Entry obgect
            if (menuNum == 1) 
            {
                // Generate the prompt
                string generatedPrompt = prompt.GeneratePrompt();
                
                // Creates new Entery object
                Entry entry = new Entry();
                entry.NewEntry(generatedPrompt);

                // Adds the entery to a Jusnal
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
                // Loads the Jurnal from the file. Prompts user for a file name
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