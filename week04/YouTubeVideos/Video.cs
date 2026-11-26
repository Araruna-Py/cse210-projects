using System.Security.Cryptography.X509Certificates;

public class Video
{
    public string _tittle;
    public string _author;
    // I accidentally wrote int value in the diagram, 
    // but actually, I will use double value:
    public double _lenghtInSeconds;
    public void GetDisplayVideoInfo()
    {
        Console.WriteLine($"{_tittle} - Made by {_author} - Total time in seconds: {_lenghtInSeconds}");
        //Console.WriteLine(CountComments());
    }

}