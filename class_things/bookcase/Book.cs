public class Book
{
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string name, string author)
    {
        _name = name;
        _author = author;
        _timesRead = 0;
        _available = true;
    }

    public bool HasAuthor(string author)
    {
       return _author.Contains(author); 
    }
    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}, it has been read {_timesRead} times");
        if(!_available)
        {
            Console.Write(", and it is not currently available, checked out");
        }
    }
    public void IsAvailable()
    {

    }
    public int TimesRead()
    {
        return _timesRead;
    }
    public void CheckOut()
    {
        _timesRead += 1;
        _available = false;
    }
    public void CheckIn()
    {

    }
}


