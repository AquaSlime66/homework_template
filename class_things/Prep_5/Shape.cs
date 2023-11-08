public class Shape{
    string _color;

    public Shape(string color){
        _color = color;
        //might be redundant uneeded
    }

    public string GetColor(){
        return _color;
    }

    public void SetColor(string color){
        _color = color;
    }

    public virtual double GetArea(){
        return _area;
    }
}