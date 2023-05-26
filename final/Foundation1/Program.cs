using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 145);
        video1.AddComment("User1", "First!");
        video1.AddComment("User2", "Super Helpful!");
        video1.AddComment("User3", "Boring!");
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 380);
        video2.AddComment("User4", "Interesting topic.");
        video2.AddComment("User5", "I JUST CAN'T STOP REWATCHING IT");
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 240);
        video3.AddComment("User6", "I agree with some flaws about that.");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine(" - Comment by " + comment.Name + ": " + comment.Text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
