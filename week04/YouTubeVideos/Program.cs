using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine("");

        Video video1 = new Video();
        Comment commentVideo1 = new Comment();
        Video video2 = new Video();
        Comment commentVideo2 = new Comment();
        Video video3 = new Video();
        Comment commentVideo3 = new Comment();

        video1._tittle = "The Board flip";
        video1._author = "CoolJamesFlips";
        video1._lenghtInSeconds = 312;
        commentVideo1._personName = "CarlCars";
        commentVideo1._comment = "Yo bro! What a cool flip!";
        commentVideo1.InfoComment();
        commentVideo1.StoreComments();
        commentVideo1._personName = "Jose338";
        commentVideo1._comment = "I think that your flip was AI... I'm not so sure...";
        commentVideo1.InfoComment();
        commentVideo1.StoreComments();
        commentVideo1._personName = "AnnaMotaniaXD";
        commentVideo1._comment = "Could you make a video teaching how you do the Flip?";
        commentVideo1.InfoComment();
        commentVideo1.StoreComments();
        commentVideo1._personName = "@lexandreMustang";
        commentVideo1._comment = "What a cool board bro!";
        commentVideo1.InfoComment();
        commentVideo1.StoreComments();
        video1.GetDisplayVideoInfo();
        commentVideo1.GetDisplayComments();
        

    }
}