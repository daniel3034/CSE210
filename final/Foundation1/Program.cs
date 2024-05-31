using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>
        {
            new Video("Understanding Abstraction in Programming", "John Doe", 600),
            new Video("Introduction to Encapsulation", "Jane Smith", 800),
            new Video("Inheritance in Object-Oriented Programming", "Alice Johnson", 900),
            new Video("Polymorphism Explained", "Bob Brown", 750)
        };

        videos[0].AddComment(new Comment("User1", "Great explanation!"));
        videos[0].AddComment(new Comment("User2", "Very helpful, thanks."));
        videos[0].AddComment(new Comment("User3", "Could you make a video on interfaces?"));
        
        videos[1].AddComment(new Comment("User4", "Clear and concise."));
        videos[1].AddComment(new Comment("User5", "Loved the examples."));
        videos[1].AddComment(new Comment("User6", "I was confused before watching this."));
        
        videos[2].AddComment(new Comment("User7", "Inheritance made easy!"));
        videos[2].AddComment(new Comment("User8", "Thanks for the insights."));
        videos[2].AddComment(new Comment("User9", "Perfect timing for my exam prep."));
        
        videos[3].AddComment(new Comment("User10", "Polymorphism is clearer now."));
        videos[3].AddComment(new Comment("User11", "Great video."));
        videos[3].AddComment(new Comment("User12", "Looking forward to more content."));

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}