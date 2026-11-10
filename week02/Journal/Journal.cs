using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry _entry in _entries)
        _entry.Display();
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter (filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}||{e._promptText}||{e._entryText}");
            }
        }
    }
}