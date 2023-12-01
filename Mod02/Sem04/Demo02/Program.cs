public class Point {
    public double X { get; set; }
    public double Y { get; set; }
    public Point(double x = 0, double y = 0) {
        X = x;
        Y = y;
    }
    public virtual double Area {
        get => 0;
    }
    public virtual void Display(){
        Console.WriteLine($"Point: x={X}, y={Y}");
    }
}

public class Circle : Point
{
    private double _r;

    public Circle(double x = 0, double y = 0, double r = 1)
        : base(x, y)
    {
        _r = r;
    }

    public double R
    {
        get => _r;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Radius of circle can't be negative.");
            }

            _r = value;
        }
    }

    public override double Area => Math.PI * Math.Pow(_r, 2);

    public override void Display()
    {
        Console.WriteLine($"Circle: x={X}, y={Y}, R={R}");
    }
}

public class Square : Point {
    private double _h;
    public Square(double x, double y, double h) : base(x, y) {
        _h = h;
    }
    public double H {
        get => _h;
        set{
            if (value < 0) {
                throw new ArgumentException("Height of square can't be negative.");
            }
            _h = value;
        }}
    public override double Area => Math.Pow(_h, 2);
    public override void Display(){
        Console.WriteLine($"Square: x={X}, y={Y}, h={_h}");
    }
}

class Program
{
    static void Main() {
        Point p = new Point();
        p.Display();
        Console.WriteLine("p.Area для Point = " + p.Area);
        p = new Circle(1, 2, 6);
        p.Display();
        Console.WriteLine("p.Area для Circle = " + p.Area);
        p = new Square(3, 5, 8);
        p.Display();
        Console.WriteLine("p.Area для Square = " + p.Area);
    }
}