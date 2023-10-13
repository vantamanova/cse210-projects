class Reference 
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    // Constructor for object with one verse
    public Reference(string book, string chapter, string verse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor for object with two verses
    public Reference (string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

}