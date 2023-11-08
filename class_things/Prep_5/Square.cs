public class Square : Shape{
    double _side;
    
    public Square(string color){
        base.SetColor(color);

        base.GetArea();

    }

    public override double GetArea()
    {
        return _side * _side;
    }



}