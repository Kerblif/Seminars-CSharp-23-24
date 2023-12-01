namespace Program;

// Класс точка.
class Point
{
// Свойства.
    public double X { get; set; }

    public double Y { get; set; }

// Конструктор без параметров.
    public Point()
    {
        X = 0;
        Y = 0;
    }

    // Конструктор с параметрами.
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Метод, вычисляющий расстояние от точки.
    public double Distance(Point point)
    {
        return Math.Sqrt((X - point.X) * (X - point.X) +
                         (Y - point.Y) * (Y - point.Y));
    }
}