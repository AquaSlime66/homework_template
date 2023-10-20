// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Player ronaldo = new Player("Christiano Ronaldo", 7);
ronaldo.Display();

Player darthvader = new Player("Darth Vader", 43);
darthvader.Display();

Teams roaches = new Teams("Roaches");
roaches.AddPlayer(ronaldo);
roaches.AddPlayer(darthvader);
roaches.DisplayRoster();