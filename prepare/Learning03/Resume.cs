public class Resume
{
    private string _name;
    private List<Job> _list_1 = new List<Job>();

    public Resume(string name)
    {
        _name = name;
    }

    public void AddJob(Job j)
    {
        _list_1.Add(j);
    }

    public void DisplayResume()
    {
        Console.WriteLine();
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _list_1)
        {
            j.Display();
            Console.WriteLine();
        }
    }

    public string GetName()
    {
        return _name;
    }

}