public class Video
{
    public string _tittle;
    public string _author;
    // I accidentally wrote int value in the diagram, 
    // but actually, I will use double value:
    public double _lenghtInSeconds;
    // I forgot to specify the type of the List:
    public List<string> _allComments;
    Comment comment;
    public void StoreComments()
    {
        string commentary = comment.InfoComment();
        _allComments.Add(commentary);
    }
    public int CountComments()
    {
        int totalComments = 0;
        foreach (string c in _allComments)
        {
            totalComments++;
        }
        return totalComments;
    }

}