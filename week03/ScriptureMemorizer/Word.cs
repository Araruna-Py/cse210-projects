//Keeps track of a single word and whether it is shown or hidden.
using System.Diagnostics;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        Show();
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            //foreach(int underline in _text.Length)
            //{}
            // I must confess that I took the next line from the internet, 
            // because I have no ideia how to use the Length in C#. I know
            // How it is in python, but sure, this is not python. I tried 
            // in many ways, but it didn't work.
            return new string('_', _text.Length);
        }
    }
}