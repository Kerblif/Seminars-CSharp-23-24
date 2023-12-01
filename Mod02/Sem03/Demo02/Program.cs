namespace Program;

static class Program
{
    public static void Main(string[] args)
    {
        Point zero = new Point(0, 0);
        Point first = new Point(3, 4);
        Point second = new Point(1.1, 2.2);
        Point third = new Point(0, 5);
        Point[] points = new Point[3] { first, second, third };
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(
                $"Расстояние от точки с координатами {points[i].X} и {points[i].Y} до начала координат равно {points[i].Distance(zero)}.");
        }
    }
}