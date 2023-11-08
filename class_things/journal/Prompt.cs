
public class Prompt
{
    public List<string> _prompts = new List<string>();

    public List<string> Prompt_list()
    {
        _prompts.Add("What was the best part of today?");
        _prompts.Add("What the most spiritually powerful moment of today?");
        _prompts.Add("How many pieces of public property have you vandalized? Were they meaningful??");
        _prompts.Add("What was on your mind most of today?");
        _prompts.Add("What was the funniest thing a friend said today?");
    }
    

  
    public void Getprompt()
    {
        var random_number = new Random();
        var _number = random_number.Next(0, _prompts.Count);
        Console.WriteLine($"{_prompts[_number]}");
    }



    //public static DisplayPrompt


///index to access the desired/chosen prompt
    
}




