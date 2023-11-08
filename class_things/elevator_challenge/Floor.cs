using System.ComponentModel.DataAnnotations;

public class Floor : Elevator{
    private int _floor;
    private bool _has_elevator;
    private bool _doorstatus;

    public Floor(int floor)
    {
        _floor = floor;
        _has_elevator = false;
        _doorstatus = false;
    }

    public void DisplayFloor(bool doorstatus, int floor){
        if (doorstatus == true){
            Console.WriteLine($"You are at floor {floor} and its door is Open. ");
         }   
        else if (doorstatus == false){
            Console.WriteLine($"You are at floor {floor} and its door is Closed");
            Open_Door(floor);
        }
    }

    public void DoorOpen(int floor){
        _doorstatus = true;
    }

    public void DoorClose(int floor){
        _doorstatus = false;
    }
    

}