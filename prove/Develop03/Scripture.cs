using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

class Scripture {
    private string _verseText; //Contains text of the verse
    private List<Word> _listWords = new List<Word>(); // Contains list with Word objects
    private string _words;
    private string _reference;

    private string _renderedText;
    private bool _isCompletlytHidden;
    private List<int> _randomNumbers = new List<int>(); // to track numbers of hidden words

    // Constructor for Scripture Class
    public Scripture() {
        // Creates a Reference object
        Reference reference = new Reference("Proverbs", "3", "5", "6");

        // Use to check how the program works with one verse scripture:
        //Reference reference = new Reference("John", "3", "16");

        _reference = reference.GetString(endVerse:true);
        
        // Creates text of the verse
        _verseText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight";

        // For checkin how the programm works with one verse
        //_verseText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        _renderedText = _verseText;
        _isCompletlytHidden = false;
    }

    // Reterns value of _isCompletlytHidden atribute to see if the text is completly hidden
    // Used in Program Class in loop to exit the program
    public bool GetStatus() {
        if (_isCompletlytHidden == true) {
            return true;
        }
        else {
            return false;
        }
    }

    // Hides words. 
    public void HideWords() {
        Console.WriteLine("");
        int i = 0;
        while ((i < 3) || (_isCompletlytHidden == true)) {
            
            // Pick random number to use it in the list to pick words to hide
            Random rnd = new Random();
            int numberOfWord = rnd.Next(0, _listWords.Count);

            // Check if the word was already hidden
            if (_listWords[numberOfWord].IsHidden() == false) {
                _listWords[numberOfWord].Hide();
                i += 1;
            }
            else {
                
            }
        }
    }

    public List<Word> CreateList() {
        // Splits phrase to words
        string[] words = _verseText.Split(" ");
        
        // Creates Word object for each word in verse 
        foreach (var item in words) {
            Word word = new Word(item, true);
            _listWords.Add(word);
        }
        return _listWords;
    }

    public void TextFunction() {
        foreach (Word element in _listWords) {
            Console.Write($"{element.GetWord()} ");
        }
    }

    public string GetRenderedText() {
        _renderedText = "";
        foreach (Word element in _listWords) {
            _renderedText += $"{element.GetWord()} ";
        }

        return _renderedText;
    }

    public void ShowScripture() {
        Console.WriteLine($"{_reference} {_renderedText}");
        
    }

    // Логика правильная
    public void IsCompletlytHidden() {
        foreach (var element in _listWords) {
            if (element.GetStatus() == false) {
                _isCompletlytHidden = false;
                break;
            }
            _isCompletlytHidden = true;

        }
    }
}