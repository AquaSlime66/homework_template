class Journal
{
    private List<Entry> _entries = new List<Entry>();
    DateTime _nowtime = DateTime.Now;

// adds the entry into the saved list of entries
    public void AddEntry(string prompt, string user_response)
    {
        Entry e = new Entry();
        e._savedtime = _nowtime;
        e._prompt = prompt;
        e._entry = user_response;
        _entries.Add(e);
    }

    public void SaveEntry(string filename)
    {
        StreamWriter writer = new StreamWriter(filename);
        foreach (Entry e in _entries)
        {
            writer.WriteLine(e._savedtime);
            writer.WriteLine(e._prompt);
            writer.WriteLine(e._entry);
        }
        writer.Close();
    }

    public void LoadSavedEntries(string filename)
    {
        _entries.Clear();
        StreamReader reader = new StreamReader(filename);
        while (!reader.EndOfStream)
        {
            string date = reader.ReadLine();
            string prompt = reader.ReadLine();
            string entry = reader.ReadLine();
            var _savedtime = DateTime.Parse(date);

            Entry e = new Entry();
            e._prompt = prompt;
            e._entry = entry;
            e._savedtime = _nowtime;
            _entries.Add(e);

        }
    }


    public void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine();
            Console.WriteLine("Date:");
            Console.Write(e._savedtime);
            Console.WriteLine("Prompt: ");
            Console.Write(e._prompt);
            Console.WriteLine("Entry: ");
            Console.Write(e._entry);
            Console.WriteLine("--------------------------END OF ENTRY--------------------------");

        }
    }

}


