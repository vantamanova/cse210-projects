using System.Diagnostics;

/// <summary>
/// This class is responsible for track of a single word and the way to hide it
/// </summary>

class Word {
    private string _word;
    private bool _isHidden = false; 

    // Constructor for a Word object
    public Word(string word) {
        _word = word;
    }

    public string GetWord() {
        string word = _word;
        return word;
    }

    public bool GetStatus() {
        if (_isHidden == true) {
            return true;
        }
        else {
            return false;
        }
    }

    public void Hide() {
        string newWord = "";
        foreach (var letter in _word)
        {
            newWord = newWord + "_";
        }
        _isHidden = true;
        _word = newWord;
    }
}
