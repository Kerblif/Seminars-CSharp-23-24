// Класс многоугольник.

public class Polygon
{
    // Число сторон.
    int numb;

    // Радиус вписанной окружности.
    double radius;

    // Конструктор по умолчанию.
    public Polygon(int n = 3, double r = 1)
    {
        numb = n;
        radius = r;
    }

    // Периметр многоугольника - свойство.
    public double Perimeter
    {
        get
        {
            double ang = ((numb - 2) * 360.0) / numb;
            double a = 2 * Math.Atan(ang / 2) * radius;

            return a * numb;
        }
    }

    // Площадь многоугольника - свойство.
    public double Area
    {
        get
        {
            return Perimeter / 2 * radius;
        }
    }

    // Данные о многоугольнике - метод.
    public string PolygonData()
    {
        string res = string.Format("N={0}; R={1}; P={2:F3}; S={3:F3}", numb, radius, Perimeter, Area);
        return res;
    }
}