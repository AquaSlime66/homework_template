public class Room{
    public List<SmartDevice> _devices = new List<SmartDevice>();

    public void setDevice(SmartDevice device) {
        _devices.Add(device);
    }
    public void getDevices(){
        foreach(SmartDevice device in _devices) {
            Console.WriteLine($"{device.GetName()} {device.GetOnOff()}");
        }
    }
    public void turnOnlights(){
        foreach(SmartDevice device in _devices) {

            if (device.GetDeviceType() == "SmartLight") {
                device.TurnDeviceOn();
            }
        }
    }
    public void turnOfflights(){
        foreach(SmartDevice device in _devices) {
            if (device.GetDeviceType() == "light") {
                device.TurnDeviceOff();
            }
        }
    }
    public void turnOnDevice(SmartDevice device){
        device.TurnDeviceOn();
    }
    public void turnOffDevice(SmartDevice device){
        device.TurnDeviceOff();
    }
    public void turnOnallDevices(){
        foreach(SmartDevice device in _devices) {
            device.TurnDeviceOn();
        }
    }
    public void turnOffAllDevices(){
        foreach(SmartDevice device in _devices) {
            device.TurnDeviceOff();
        }
    }
    public void getLongest(){

    }
}