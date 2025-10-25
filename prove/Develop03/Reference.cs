using System;
using System.ComponentModel;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;
    private static List<string> books = new List<string>();
    private static List<int> chapters = new List<int>();
    private static List<int> startVerses= new List<int>();
    private static List<int?> endVerses = new List<int?>();
    public static void GenerateReferences()
    {
        books.Add("Genesis");
        chapters.Add(1);
        startVerses.Add(1);
        endVerses.Add(null);

        books.Add("3 Nephi");
        chapters.Add(11);
        startVerses.Add(10);
        endVerses.Add(11);

        books.Add("John");
        chapters.Add(3);
        startVerses.Add(16);
        endVerses.Add(null);
    }
    public Reference(int chosenScripture)
    {
        _book = books[chosenScripture];
        _chapter = chapters[chosenScripture];
        _startVerse = startVerses[chosenScripture];
        _endVerse = null;

    } 
    public Reference(int chosenScripture, bool hasEndVerse)
    {
        _book = books[chosenScripture];
        _chapter = chapters[chosenScripture];
        _startVerse = startVerses[chosenScripture];
        if (hasEndVerse)
        {
            _endVerse = endVerses[chosenScripture];
        }
        
    }

    public string CreateReference()
    {
        if (_endVerse == null)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}