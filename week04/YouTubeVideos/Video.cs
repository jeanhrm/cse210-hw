using System;
using System.Collections.Generic;

public class Video
{

    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

   
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Title:   {_title}");
        Console.WriteLine($"Author:  {_author}");
        Console.WriteLine($"Length:  {_lengthInSeconds} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}
