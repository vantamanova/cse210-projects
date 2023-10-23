using System.Dynamic;

/// <summary>
/// This class is responsible for keepin track of the book, chapter and verse information
/// </summary>

class Reference 
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _referenceStr;

    // Constructor for object with one verse
    public Reference(string book, int chapter, int verse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor for object with two verses 
    public Reference (string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse; 

    }

    public string GetString(bool endVerse = false) {
        string reference; 

        if (endVerse == false) {
            reference = $"{_book} {_chapter}: {_verse}";
        }
        else {
            reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        _referenceStr = reference;
        return reference;
    }

}