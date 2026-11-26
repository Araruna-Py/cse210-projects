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
        Console.WriteLine("");
        Console.WriteLine($"Total comments: {commentVideo1.CountComments()}");

        Console.WriteLine("");
        Console.WriteLine("");

        video2._tittle = "How to cook a Homemade Hamburguer";
        video2._author = "MisClaraChef";
        video2._lenghtInSeconds = 615;
        commentVideo2._personName = "Gabe.95";
        commentVideo2._comment = "Seems delicious!";
        commentVideo2.InfoComment();
        commentVideo2.StoreComments();
        commentVideo2._personName = "Jose338";
        commentVideo2._comment = "I think that your homemade hamburguer is fake... I'm not so sure...";
        commentVideo2.InfoComment();
        commentVideo2.StoreComments();
        commentVideo2._personName = "BrazilCooker";
        commentVideo2._comment = "Could you make a video teaching how to cook a homemade bread?";
        commentVideo2.InfoComment();
        commentVideo2.StoreComments();
        video2.GetDisplayVideoInfo();
        commentVideo2.GetDisplayComments();
        Console.WriteLine("");
        Console.WriteLine($"Total comments: {commentVideo2.CountComments()}");

         Console.WriteLine("");
         Console.WriteLine("");
        
        video3._tittle = "Nitento: Pokemon New Horizons trailer";
        video3._author = "PokemonClan";
        video3._lenghtInSeconds = 172;
        commentVideo3._personName = "JonHarkson";
        commentVideo3._comment = "When will this game be released?";
        commentVideo3.InfoComment();
        commentVideo3.StoreComments();
        commentVideo3._personName = "Jose338";
        commentVideo3._comment = "Stupid game! Is the same thing always!!!";
        commentVideo3.InfoComment();
        commentVideo3.StoreComments();
        commentVideo3._personName = "PokemonTrainersCenter";
        commentVideo3._comment = "I'm buying this game for sure!";
        commentVideo3.InfoComment();
        commentVideo3.StoreComments();
        video3.GetDisplayVideoInfo();
        commentVideo3.GetDisplayComments();
        Console.WriteLine("");
        Console.WriteLine($"Total comments: {commentVideo3.CountComments()}");
    }
}