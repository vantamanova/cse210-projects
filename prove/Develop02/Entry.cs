using System.Runtime.CompilerServices;
using System.Transactions;

/// <summary>
/// This is the class responsible for creatin and holdin information
/// about the curent entry
/// 
/// To exceed the requerments I've created one more attribute for this class _mood.
/// It is displayd and saved to a file with the resf of data
/// </summary>
class Entry
{
    public string _answer;
    public string _date;
    public string _prompt;
    public string _mood;

    public void NewEntry(string prompt) {
        //Getting curent date
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        // storing prompt as an attribute
        _prompt = prompt;

        // getting users input for _answer and storing it as an atribbute
        Console.Write("> ");
        _answer = Console.ReadLine();
        Console.WriteLine();

        // Getting users input for _mood and storing it as an attrubute
        Console.Write("Discribe how you feel in one word > ");
        _mood = Console.ReadLine();
        
    }
    public void ShowEntry() {
        Console.WriteLine(_prompt);
        Console.WriteLine($"Date: {_date}: {_answer}");
        Console.WriteLine($"I feel {_mood}");
    }
}