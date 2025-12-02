using System;
class Comment
{ 
    private string _personName;
    private string _commentText;

    public Comment(string personName, string commentText)
    {
        _personName = personName;
        _commentText = commentText;
    }
    public string GetPersonName()
    {
        return _personName;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_personName}: {_commentText}");
    }
}