using System.Diagnostics;

class Word {
    private string _word;
    private bool _isHidden = false;

    // Construcror for a Word object
    public Word(string word, bool showOrHide = true) {
        _word = word;
        showOrHide = true;
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
    /*public string Show() {
        string word = _word;
        return word;
    }*/ //do I need it?

    public void Hide() {
        string newWord = "";
        foreach (var letter in _word)
        {
            newWord = newWord + "_";
        }
        _isHidden = true;
        _word = newWord;
    }

    public bool IsHidden() {
        return _isHidden;
    }
}
