public class Program
{
    public static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();


        Video video1 = new Video("C# Basics", "John Mill", 300);
        video1.AddComment(new Comment("Maria", "I can finally understand encapsulation."));
        video1.AddComment(new Comment("Bart", "The metaphor really helped me understand."));
        video1.AddComment(new Comment("Carol", "I'm starting with C#, is there anything you wish you would learn earlier?"));
        videos.Add(video1);

        Video video2 = new Video("Advanced C#", "Jane Connor", 3900);
        video2.AddComment(new Comment("Dave", "I don't know how I got here."));
        video2.AddComment(new Comment("Grace", "How can a 1 hour long video be so interesting."));
        video2.AddComment(new Comment("Frank", "Please make more videos like this."));
        video2.AddComment(new Comment("Freddy", "I got a misconception of a few programming terms but this video helped me."));
        videos.Add(video2);

        Video video3 = new Video("SQL Tutorial", "Marcelo Debil", 400);
        video3.AddComment(new Comment("Hannah", "SQL seems so easy now."));
        video3.AddComment(new Comment("Randy", "After this video I will stop using Excel."));
        video3.AddComment(new Comment("Jack", "Thanks for the key shortcuts."));
        videos.Add(video3);

        Video video4 = new Video("JavaScript Basics", "Estefy Foster", 900);
        video4.AddComment(new Comment("Laura", "It says basics but still a complicated topic. for me at least."));
        video4.AddComment(new Comment("Matt", "I hope you make a video about API's soon."));
        video4.AddComment(new Comment("Nico", "Well, I can say I tried."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}