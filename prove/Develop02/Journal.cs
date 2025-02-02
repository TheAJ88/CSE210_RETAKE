using System;


public class Journal2
{
    public string _fileName;
    public List<Entry> _entries= new List<Entry>();

    public void EntryManager()
    {
        Entry e2 = new Entry(); 
        e2.journalEntry();
        _entries.Add(e2); 
    }

    public void Display()
    {
        foreach(Entry e in _entries)
        {
            e.Display();
        }
    }

    public void Savefile(string fileName)
    {
        if (File.Exists(fileName))
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    sw.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entryText}");
                }
            }
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entryText}");
                }
            }
        }
            
    }

    public void Loadfile(string f)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(f);
        foreach(string line in lines)
        {
            string[] parts = line.Split("~~");
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            
            Entry e = new Entry();
            e._date = date;
            e._prompt = prompt;
            e._entryText = entry;
            _entries.Add(e);
        }
    }
}