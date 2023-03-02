public class Square : Shape {

    private double _side;

    public Square(string color, double newSide) : base (color){
        _side = newSide;
    }

    public override double getArea(){
        return _side * _side;
    }
}