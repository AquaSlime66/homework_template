public class Match
{
    private Teams _team1;
    private Teams _team2;
    public Match(Teams team1, Teams team2)
    {
        _team1 = team1;
        _team2 = team2;
    }

    public void DecideWin()
    {
        Console.WriteLine("Which Team won? ");
        Console.WriteLine($"1 {_team1.GetTeamName()}");
        Console.WriteLine($"2 {_team2.GetTeamName()}");
        string winner = Console.WriteLine();
        if(winner == "1")
        {
            _team1.AddWin();
            _team2.AddLosses();
        }
        else
        {
            _team1.AddLosses();
            _team2.AddWin();
        }
    }
}