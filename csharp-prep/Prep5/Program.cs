using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        
        
        void DisplayIntro()
        {
            Console.WriteLine("Welcome to the Name and Number Program! ");
        }

        static string your_name()
        {
            //string your_name2 = "yes";
            Console.WriteLine("What is your name? ");
            string your_name2 = Console.ReadLine();
            return your_name2;
        }

        static int favorite_number()
        {
            Console.WriteLine("What is your favorite number? ");
            int favorite_number2 = int.Parse(Console.ReadLine());
            return favorite_number2;
        }

        static int squared_number(int the_number)
        {
            int squared = the_number * the_number;
            return squared;
        } 

        static string combination_time(string name, int square_number)
        {
            Console.Write(name);
            Console.Write(", your favorite number squared is ");
            Console.Write(square_number);
            return "yes";
        }

        DisplayIntro();
        string named = your_name();
        int ye_number = favorite_number();
        int squared_number2 = squared_number(ye_number);
        combination_time(named, squared_number2);

    }
}

//25552