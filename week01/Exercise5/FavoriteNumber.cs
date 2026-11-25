public class FavoriteNumber
{
    private string _userFavoriteNumber;
    public int IntNumber(string userNumber)
    {
        userNumber = _userFavoriteNumber;
        int number = int.Parse(userNumber);
        return number;
    }
}




        //public List<FavoriteNumber> _userFavoriteNumber = new List<FavoriteNumber>();