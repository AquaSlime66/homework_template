public class Scripture
{
    private string _scripture;
    private List<Word> _words = new List<Word>();
    private List<Word> _tempwords = new List<Word>();
    //private List<Word> _scripture = new List<Word>();

    public Scripture()
    {
        //_scripture = "Daryl stop hitting the Griddy in front of the Walkers.";
        
        //string[] _word_list = _scripture.Split(" ");
    }

    public void AddWord(Word word)
    {
        _words.Add(word);
    }

    public void Display_Scrip()
    {
        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
    }

    public void Display_Scrip_hidden()
    {
        foreach (Word word in _words)
        {
            word.DisplayWord_hidden();
        }
        float percent_hid = 0;
        float total_percent = 0;
        foreach (Word word in _words){
            bool word_bool = word.ReturnTheSlab();
            if (word_bool == true){
                percent_hid++;
            }
            else{ 
            }
            total_percent++;
        }
        Console.WriteLine();
        Console.WriteLine($"{Math.Round((percent_hid / total_percent) * 100)}% is hidden");
        
        
    }

    

    public bool EndProgram(){
        float percent_hid = 0;
        float total_percent = 0;
        foreach (Word word in _words){
            bool word_bool = word.ReturnTheSlab();
            if (word_bool == true){
                percent_hid++;
            }
            else{ 
            }
            total_percent++;
        }
        if ((percent_hid / total_percent) * 100 == 100){
            return false;
        }
        else {
            return true;
        }
        //this is the progress part 
        
    }
    


    
  

}