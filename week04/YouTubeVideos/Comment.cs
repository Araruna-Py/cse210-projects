public class Comment
{
    public string _personName;
    public string _comment;
    //public Comment _commentary;
    public List<string> _allComments = new List<string>();
    public string InfoComment()
    {
        string comment = "";
        return comment = ($"{_personName}: {_comment}");
    }
    public void StoreComments()
    {
        string comments = InfoComment();
        _allComments.Add(comments);
    }
    public void GetDisplayComments()
    {
        foreach (string c in _allComments)
        {
            Console.WriteLine(c);
        }
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