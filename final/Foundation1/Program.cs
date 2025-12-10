using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

class Program
{
    private static List<Video> _videoList = new List<Video>();
    static void Main(string[] args)
    {
        Console.WriteLine("Abstraction with YouTube Videos");
        Console.WriteLine();
        Video video1 = new Video("My First Video", "Naya Delacruz", 300, new List<Comment>());
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing!"));
        _videoList.Add(video1);

        Video video2 = new Video("Learning C#", "Joseph Smith", 450, new List<Comment>());
        video2.AddComment(new Comment("Dave", "This helped me a lot."));
        video2.AddComment(new Comment("Eve", "Well explained."));
        video2.AddComment(new Comment("Mallory", "Looking forward to more videos."));
        _videoList.Add(video2);

        Video video3 = new Video("Enduring College", "Jane Hopper", 600, new List<Comment>());
        video3.AddComment(new Comment("Frank", "Can't wait to try this out."));
        video3.AddComment(new Comment("Grace", "Excellent content!"));
        video3.AddComment(new Comment("Heidi", "Very detailed."));
        video3.AddComment(new Comment("Ivan", "Loved the examples."));
        _videoList.Add(video3);

        foreach (Video video in _videoList)
        {
            video.DisplayVideo();
            Console.WriteLine($"Total Comments: {video.GetCommentCount()}");
            Console.WriteLine();
        }
    }
}