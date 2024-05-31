using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; } // in seconds
    private List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
        }
    }
}
