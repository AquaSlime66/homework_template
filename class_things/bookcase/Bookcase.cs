public class Bookcase
{
    public Bookcase()
    {
        //constructer necisito
    }
    private List<Book> _books = new List<Book>();
    public void AddBook(Book b)
    {
        _books.Add(b);
    }
    public void ShowBooks()
    {
        foreach (Book b in _books)
        {
            b.Display();
            Console.WriteLine();
        }
    }



}