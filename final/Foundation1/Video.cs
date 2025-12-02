using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = comments;
    }
    
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }   
    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public Comment GetComment(int index)
    {
        if (index >= 0 && index < _comments.Count)
        {
            return _comments[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Comment index is out of range.");
        }
    }
    public void DisplayCommentCount(List<Comment> comments)
    {
        int commentCount = comments.Count;
        Console.WriteLine($"Number of comments: {commentCount}");
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_lengthInSeconds}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
    

}