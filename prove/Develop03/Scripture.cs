using System;
using System.Collections.Generic;

class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private int _wordToDisplayCount;
    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
        _wordToDisplayCount = _words.Count;
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenWords = 0;
        while (hiddenWords < count && !CompletelyHidden())
        {
            int randomIndex = random.Next(0, _words.Count);
            if (_words[randomIndex].IsHidden() == false)
            {
                _words[randomIndex].Hide();
                hiddenWords++;
                _wordToDisplayCount--;
            }
        }
    }

    public string GetRenderedText()
    {
        string renderedText = _reference.CreateReference() + " ";
        foreach (Word word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText.Trim();
    }

    public bool CompletelyHidden()
    {
        return _wordToDisplayCount <= 0;
    } 
}