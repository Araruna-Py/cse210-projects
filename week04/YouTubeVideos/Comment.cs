public class Comment
{
    public string _personName;
    public string _comment;
    public string InfoComment()
    {
        return ($"{_personName}: {_comment}");
    }
}