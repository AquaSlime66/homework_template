public class Job
{
    private string _company;
    private string _jobtitle;
    private int _startYear;
    private int _endYear;

    public Job(string company, string jobtitle, int start, int end)
    {
        _company = company;
        _jobtitle = jobtitle;
        _startYear = start;
        _endYear = end;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startYear}-{_endYear}");
    }

}
