using System.Runtime.CompilerServices;
using System.Transactions;

/// <summary>
/// This class is responsible for generating the random prompt from the list
/// List with prompts is provided.
/// </summary>
class PromptGenerator
{
    
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the worst thing that happened today?",
        "What was the most challenging thing I faced today?",
        "What am I grateful for today?",
        "What was the most fun thing I did today?",
        "What is the current problem or challenge I am facing?",
        "How do I get to use my creativity on a daily basis?",
        "Write a poem about a childhood memory that has stayed with you.",
    };

    public string GeneratePrompt() {
        Random rnd = new Random();
        int num = rnd.Next(0, _prompts.Count);
        string prompt = _prompts[num];
        Console.WriteLine($"{prompt}");
        return prompt;
    }
    
}
