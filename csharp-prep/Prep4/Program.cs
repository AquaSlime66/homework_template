using System;

class Program
{
    static void Main(string[] args)
    {
        int users_add = -2;

        List<int> numbers_list = new List<int>();

        while (users_add != 0)
        {
            Console.WriteLine("What is the number you'd like to add? ");
            users_add = int.Parse(Console.ReadLine());
            if (users_add != 0)
            {
                numbers_list.Add(users_add);
            }
        }
        
        int total_sum = 0;
        foreach (int single_number in numbers_list)
        {
            total_sum += single_number;
        }

        int highest_number = 0;
        foreach (int test_number in numbers_list)
        {
            if (test_number > highest_number)
            {
                highest_number = test_number;
            }
        }


        //amount_2 = (numbers_list.Count());


        Console.WriteLine(total_sum / numbers_list.Count);
        

        Console.Write("The total sum is ");
        Console.Write(total_sum);

        Console.WriteLine();

        Console.Write("The average is ");
        Console.Write(total_sum / numbers_list.Count);

        Console.WriteLine();

        Console.Write("The highest number is ");
        Console.Write(highest_number);
        

    }
}