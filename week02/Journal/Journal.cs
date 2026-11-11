using System.IO;
using System.Security.Cryptography.X509Certificates;
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
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
        }
    }
    public string _date;
    public string _promptText;
    public string _entryText;

    public void LoadFromFile(string filename)
    {
        
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry oldEntries = new Entry();
            string[] parts = line.Split("|");
            oldEntries._date = parts[0];
            oldEntries._promptText = parts[1];
            oldEntries._entryText = parts[2];
            AddEntry(oldEntries);
        }
    }
}