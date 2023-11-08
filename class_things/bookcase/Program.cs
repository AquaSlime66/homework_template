// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Book hp = new Book("Harry Potter", "JK Rowling");
hp.Display();

Bookcase bob = new Bookcase();
bob.AddBook(hp);

bob.ShowBooks();