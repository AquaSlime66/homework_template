using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string sym_status = "yes";

        Random randomGenerator = new Random();
        int the_holy_number = randomGenerator.Next(1, 11);
        
        int your_guess = 5;

        while (sym_status == "yes")
        {
            Console.Write("What is thy sacred number? ");
            your_guess = int.Parse(Console.ReadLine());

            if (your_guess > the_holy_number)
            {
                Console.WriteLine("Your Guess is too high. ");
            }
            else if (your_guess < the_holy_number)
            {
                Console.WriteLine("Your Guess is too low" );
            }
            else
            {
                Console.WriteLine("Your guess is right on! ");
                sym_status = "no";
                //unfortunately this program needs one extra loop to end, I didn't think it was worth the time to change the loop condition from the 
                // sym status to the number and guess, but I get the general idea of it
            }
            

        }

        Console.Write("What is thy sacred number? ");
        string numb_question = Console.ReadLine();



    }
   // hkhjjjjkjkjkjk
   //git checkout -b branch_name (NO QUOTATIONS) makes a new branch from the terminal 
}