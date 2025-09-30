using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("YouTube Video Program");
        Console.WriteLine("---------------------\n");

        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learn C# Basics", "John Smith", 600);
        video1.AddComment(new Comment("Alice", "Great explanation, thanks!"));
        video1.AddComment(new Comment("Bob", "Very clear and helpful."));
        video1.AddComment(new Comment("Charlie", "Could you make one on classes?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Object-Oriented Programming", "Mary Johnson", 750);
        video2.AddComment(new Comment("David", "Now I understand encapsulation."));
        video2.AddComment(new Comment("Eva", "Helpful for my assignment."));
        video2.AddComment(new Comment("Frank", "Looking forward to inheritance!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("C# Lists and Collections", "James Brown", 500);
        video3.AddComment(new Comment("Grace", "The examples are very practical."));
        video3.AddComment(new Comment("Henry", "Thanks for simplifying the topic."));
        video3.AddComment(new Comment("Ivy", "This really helped me study."));
        videos.Add(video3);

        // Show all videos and their comments
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}


