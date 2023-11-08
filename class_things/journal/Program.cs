// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Prompt entry = new Prompt();
        //From Prompt(Prompts)
        //LOOK HERE BRO
        // set stuff to public for acessiblilty within the main program, without typing out public auto set to private
        //need instance of the journal for journal saving and loading, might already have??
        //if not public, a file handler program will return a list of entries enabling that single instance as public and accesible
        // _ for variables are referenced inside the class, but without _ it is only referenced inside of the single method/class?
        

        string status_check = "None";
    
        while (status_check != "quit")
        {
            int user_number = 0;
           Console.WriteLine("Welcome to the Journal Program!");
           Console.WriteLine("Please enter the number associated with your desired command: ");
           Console.WriteLine("1: Create New Entry");
           Console.WriteLine("2: Display Locally saved Entries");
           Console.WriteLine("3: Load Hard-Saved Entries");
           Console.WriteLine("4: Save Locally saved Entries");
           Console.WriteLine("5: Quit program");
           user_number = int.Parse(Console.ReadLine());


            if (user_number == 1)
            {
                //public List<string> returned_chunk = new List<string>();
                //didn't work because public can only be declared in classes not programs?
                int prompt_number = 0;

                Console.WriteLine("\nDo you want to create a new entry based off of a random prompt, or choose a prompt? \n Type the associated number with your chosen prompt or type anything to get a random one (that's not one of these numbers)\n");
                //Console.WriteLine("Do you want to create a new entry based off of a random prompt, or choose a prompt?");
                //Console.WriteLine("Type the associated number with your chosen prompt or type anything to get a random one (that's not one of these numbers) \n");
                //Console.WriteLine();

                int count = 0;

                foreach(string one_entry in entry._prompts)
                {
                    count += 1;
                    Console.WriteLine($"{count}. {one_entry}");
                }

                //List<string> returned_chunk = new List<string>();

                prompt_number = int.Parse(Console.ReadLine());
    
                if (prompt_number == 1)
                {
                    // use the prompt index
                    string saved_prompt = entry._prompts[prompt_number];
;                    Entry entry_1 = new Entry();
                    //ask for function that auto asks user for their thing?
                    Console.WriteLine(entry._prompts[prompt_number]);
                } 
                else if (prompt_number == 2)
                {
                    string chosen_prompt = "What the most spiritually powerful moment of today?";
                } 
                else if (prompt_number == 3)
                {
                    string chosen_prompt = "How many pieces of public property have you vandalized? Were they meaningful??";
                } 
                else if (prompt_number == 4)
                {
                    string chosen_prompt = "What was on your mind most of today?";
                } 
                else if (prompt_number == 5)
                {
                    string chosen_prompt = "What was the funniest thing a friend said today?";
                } 
                else 
                {
                    //Console.WriteLine("else statement");
                     //var random_number = new Random();
                    //var _number = random_number.Next(0, _prompts.Count);
                    //Console.WriteLine($"{_prompts[_number]}");
                }
                
            }
            if (user_number == 2)
            {
                //Journal.LoadSavedEntries();
            }
            if (user_number == 5)
            {
                status_check = "quit";
            }
        }
    }
}
    