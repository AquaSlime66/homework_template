public class Elevator {
    //private bool _doorstatus;
    //move to floor
    private int _current_floor;
    private bool _isprivate;

    public void StartFloor(bool password){
        Console.WriteLine("What floor do you want to go to? ");
        int currentfloor = int.Parse(Console.ReadLine());
        if (currentfloor <= 30){
            Open_Door(currentfloor);
        }
        else if (currentfloor <= 31 and password == true){
            Open_Door(currentfloor);
        }
        else{
            Console.WriteLine("This floor isn't currently acccessible to you");
        }
    }

    public void VIP_Mover(int password){
        if (password == 1234){
            StartFloor(true);
        }
        else{
            Console.WriteLine("Wrong password loser");
        }
    }

    public void Open_Door(int floor_number){
        Console.WriteLine($"Floor {floor_number} door is open");
    }

    public void MoveFloor(int floor){

    }

    public void ShowAvalibleFloors(int currentfloor, bool password){
        Console.WriteLine("The currently avalible floors are; ");
        if (password){
            for (int i= 1; i <31; i++){
                if (i != currentfloor){
                    Console.Write(i);
                    Console.Write(", ");
                }

            }
        }
    }

}