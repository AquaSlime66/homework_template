public class Entry
{
    public DateTime _savedtime;
    public string _prompt;
    public string _entry;

    public void DisplayEntry(DateTime _savedtime, string _prompt, string _entry)
    {
        Console.WriteLine($"{_savedtime}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_entry}");
    }
}
