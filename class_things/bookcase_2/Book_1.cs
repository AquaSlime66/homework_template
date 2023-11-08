public class Book_1 : Loanable{
    private string _title;
    private string _isbn;
    private int _upc;
    public Book_1(string title, string isbn,int upc){
        _title = title;
        _isbn = isbn;
        _upc = upc;
    }

    public override void Display()
    {
        Console.WriteLine($"{_title}, {_isbn}, {_upc}");
        base.Display();
    }

}