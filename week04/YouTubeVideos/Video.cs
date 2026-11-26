using System.Security.Cryptography.X509Certificates;

public class Video
{
    public string _tittle;
    public string _author;
    // I accidentally wrote int value in the diagram, 
    // but actually, I will use double value:
    public double _lenghtInSeconds;
    // I forgot to specify the type of the List:
    //public List<Comment> _allComments;
    ////public void StoreComments(Comment allComments)
    //public void StoreComments()
    //{
    //Comment comment = new Comment();
    //    _allComments.Add(comment.InfoComment());
    //}
    //public void GetDisplayComments()
    //{
    //    foreach (string c in _allComments)
    //    {
    //        Console.WriteLine(c);
    //    }
    //}
    //public int CountComments()
    //{
    //    int totalComments = 0;
    //    foreach (string c in _allComments)
    //    {
    //        totalComments++;
    //    }
    //    return totalComments;
    //}
    public void GetDisplayVideoInfo()
    {
        Console.WriteLine($"{_tittle} - Made by {_author} - Total time in seconds: {_lenghtInSeconds}");
        //Console.WriteLine(CountComments());
    }

}