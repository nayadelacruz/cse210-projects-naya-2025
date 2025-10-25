using System;
using System.Collections.Generic;

class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private int _wordToDisplayCount;

    private static List<string> scriptures = new List<string>();
    public static void InitializeScriptures()
    {
        scriptures.Add("In the beginning God created the heaven and the earth.");
        scriptures.Add("Behold, I am Jesus Christ, whom the prophets testified shall come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.");
        scriptures.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    }   

    public static string GetScriptureText(int index)
    {
        if (index >= 0 && index < scriptures.Count)
        {
            return scriptures[index];
        }
        else
        {
            throw new ArgumentOutOfRangeException("Index is out of range of available scriptures.");
        }
    }
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