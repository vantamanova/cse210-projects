using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

/// <summary>
/// This class is responsible for keeping track of the reference and text of the scripture.
/// </summary>

class Scripture {
    private string _verseText; //Contains text of the verse
    private static List<Word> _listWords = new List<Word>(); // Contains list with Word objects
    private string _reference; // Contiains the reference
    private string _renderedText; // Text which will be shown in the console
    private static bool _isCompletlytHidden; // true if the text is completly hidden
    private static List<Word> _randomWord = new List<Word>();

    // Constructor for Scripture Class
    public Scripture() {
        // Creates a Reference object
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Use to check how the program works with one-verse scripture:
        //Reference reference = new Reference("John", 3, 16);

        _reference = reference.GetString(endVerse:true);
        
        // Creates text of the verse
        _verseText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.";

        // Use to check how the program works with one-verse scripture:
        //_verseText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        _renderedText = _verseText;
        _isCompletlytHidden = false;
    }

    // Returns value of _isCompletlytHidden attribute to see if the text is completely hidden
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

        while (true) {

            // Creates list with words which were not used
            _randomWord = _listWords.Where(word => word.GetStatus() == false).ToList();

            if (_randomWord.Count == 0) {
                _isCompletlytHidden = true;
                break;
            }

            if (i == 3) {
                break;
            }

            // Picks random number
            Random rnd = new Random();
            int numberOfWord = rnd.Next(0, _randomWord.Count);

            string word = _randomWord[numberOfWord].GetWord();

            // Hides the Word
            foreach (var element in _listWords) {
                if (element.GetWord() == word) {
                    element.Hide();
                    i += 1;
                    break;
                }
            }
        }
    }


    public List<Word> CreateList() {
        // Splits phrase to words
        string[] words = _verseText.Split(" ");
        
        // Creates Word object for each word in verse 
        foreach (var item in words) {
            Word word = new Word(item);
            _listWords.Add(word);
        }
        return _listWords;
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


    /*static bool AllTextIsHidden() {
        bool textIsHidden = true;

       foreach (var element in _listWords) {
            if (element.GetStatus() == true) {
            }
            else {
                textIsHidden = false;
            }
       }
       _isCompletlytHidden = textIsHidden;
       return textIsHidden;
    }*/
}