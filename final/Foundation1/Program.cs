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

        videos[0].AddComment(new Comment("nisto", "Great explanation!"));
        videos[0].AddComment(new Comment("honte", "Very helpful, thanks."));
        videos[0].AddComment(new Comment("crout", "Could you make a video on interfaces?"));
        
        videos[1].AddComment(new Comment("antho", "Clear and concise."));
        videos[1].AddComment(new Comment("stort", "Loved the examples."));
        videos[1].AddComment(new Comment("rownp", "I was confused before watching this."));
        
        videos[2].AddComment(new Comment("dista", "Inheritance made easy!"));
        videos[2].AddComment(new Comment("onger", "Thanks for the insights."));
        videos[2].AddComment(new Comment("ecome", "Perfect timing for my exam prep."));
        
        videos[3].AddComment(new Comment("thito", "Polymorphism is clearer now."));
        videos[3].AddComment(new Comment("eryde", "Great video."));
        videos[3].AddComment(new Comment("iandr", "Looking forward to more content."));

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}