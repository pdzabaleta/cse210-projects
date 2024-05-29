using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Learn C#", "John Doe", 600);
        Video video2 = new Video("C# Advanced Tutorial", "Jane Smith", 1200);
        Video video3 = new Video("Understanding OOP in C#", "Emily Johnson", 800);

        // addding comments

        video1.AddComment(new Comment("Alice", "Great video, very helpful!"));
        video1.AddComment(new Comment("Bob", "Thanks for the tutorial."));
        video1.AddComment(new Comment("Charlie", "Awesome content!"));

        video2.AddComment(new Comment("Dave", "This is exactly what I needed."));
        video2.AddComment(new Comment("Eve", "Very detailed and clear."));
        video2.AddComment(new Comment("Frank", "Helped me a lot, thanks!"));

        video3.AddComment(new Comment("Grace", "Excellent explanation of OOP."));
        video3.AddComment(new Comment("Heidi", "I learned so much from this."));
        video3.AddComment(new Comment("Ivan", "Perfect examples and explanations."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console. WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommentName()}: {comment.GetText()}");
            }
            Console.WriteLine(); //blank
        }
    }
}