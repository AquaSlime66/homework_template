public class SmartDevice{
    private bool _activatable;
    private bool _on_off;
    private DateTime _time_on;
    private string _device_name;
    private string _type;

    public SmartDevice(bool activatable, string device_name, string type) {
        _on_off = false;
        _activatable = activatable;
        _device_name = device_name;
        _type = type;
    }
    public void TurnDeviceOn(){
        _time_on = DateTime.Now;
        _on_off = true;
    }
    public void TurnDeviceOff(){
        _on_off = false;
    }

    public DateTime GetStartTime(){
        return _time_on;
    }

    public string GetDeviceType() {
        return _type;
    }

    public string GetName(){
        return _device_name;
    }
    public bool GetOnOff() {
        return _on_off;
    }
}