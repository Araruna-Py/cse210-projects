//Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
using System.Diagnostics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] parts = text.Split(" ");
        foreach (string word in parts)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int listIndex = randomGenerator.Next(0,_words.Count);
            _words[listIndex].Hide();
        }

    }
    public string GetDisplayText()
    {
        string scriptureVerse = _reference.GetDisplayText() + " ";
        foreach (Word w in _words)
        {
            scriptureVerse += w.GetDisplayText() + " ";
        }
        return scriptureVerse;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}