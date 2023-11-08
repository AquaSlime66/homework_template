// See https://aka.ms/new-console-template for more information

Reference r = new Reference("D&C",66,6);
Scripture scrip_retardation = new Scripture();
string texter = "Tarry not many days in this place; go anot up unto the land of Zion as yet; but inasmuch as you can send, send; otherwise, think not of thy property.";
List<string> splitUp = texter.Split(" ").ToList();
foreach (var item in splitUp)
{
    Word word = new Word(item);
    scrip_retardation.AddWord(word);
}

r.DisplayRef();
scrip_retardation.Display_Scrip();
Console.WriteLine();

bool sym_status = true;
int placeholder = 1;

while (sym_status == true)
{
    string user_input = Console.ReadLine() ?? string.Empty;
    if (user_input == "")
    {
        Console.Clear();
        r.DisplayRef();
        scrip_retardation.Display_Scrip_hidden();
        bool new_status = scrip_retardation.EndProgram();
        Console.WriteLine(new_status);
        if (new_status == true){
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press anything to quit other than Enter");
        }
        else if (new_status == false){
            Console.WriteLine();
            Console.WriteLine("All words, are hidden, program terminated. ");
            sym_status = false;
        }
        
    }
        
    
    else 
    {
        sym_status = false;
    }
}




