// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Loanable cat = new Loanable();

cat.Display();
cat.CheckOut();
cat.Display();

Dvd star_wars = new Dvd("Star Wars");
star_wars.Display();

star_wars.CheckOut();
star_wars.Display();

Book_1 mice = new Book_1("Of mice and men", "7654", 987);
mice.Display();
mice.CheckOut();
mice.Display();