using ToDo04_05_06;

Point a, b, c;

a = new Point(3, 4);
Console.WriteLine(a.PointData);

b = new Point(0, 3);
Console.WriteLine(b.PointData);

c = new Point();
double x = 0, y = 0;

do
{
    Console.Write("x = ");
    double.TryParse(Console.ReadLine(), out x);

    Console.Write("y = ");
    double.TryParse(Console.ReadLine(), out y);

    c.X = x; c.Y = y;

    // ToDo 06:

    Console.WriteLine(c.PointData);
    
    Point min, middle, max;
    
    double minRo = Math.Min(a.Ro, Math.Min(b.Ro, c.Ro));
    double maxRo = Math.Max(a.Ro, Math.Max(b.Ro, c.Ro));

    if (minRo == a.Ro) min = a;
    else if (minRo == b.Ro) min = b;
    else min = c;

    if (maxRo == a.Ro && a != min) max = a;
    else if (maxRo == b.Ro && b != min) max = b;
    else max = c;

    if(a != min && a != max) middle = a;
    else if(b != min && b != max) middle = b;
    else middle = c;

    Console.WriteLine("\nВывод в порядке возрастания расстояния.");
    Console.WriteLine(min.PointData);
    Console.WriteLine(middle.PointData);
    Console.WriteLine(max.PointData);

} while (x != 0 | y != 0);



