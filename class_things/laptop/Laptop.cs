public class Laptop {
    private double _screen_size;
    private string _os;
    private bool _touchscreen;

    public Laptop(double screen_size, string os, bool ts)
    {
        _screen_size = screen_size;
        _os = os;
        _touchscreen = ts;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{_screen_size} {_os} {_touchscreen}");
    }


}