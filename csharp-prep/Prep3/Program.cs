using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string sym_status = "yes";

        Random randomGenerator = new Random();
        int the_holy_number = randomGenerator.Next(1, 11);

        while (sym_status == "yes")
        {
            Console.Write("What is thy sacred number? ");
            your_guess = int.Parse(Console.ReadLine());

            if (your_guess > the_holy_number)
            {

            }

            Console.Write("Would you like to guess again? ");
            sym_status = Console.ReadLine();

        }

        Console.Write("What is thy sacred number? ");
        string numb_question = Console.ReadLine();



    }
}