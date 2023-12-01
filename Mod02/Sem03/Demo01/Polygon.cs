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
            // Аксессор свойства.
            // ToDo 01: реализовать свойство подсчета периметра многоугольника
            return 0;
        }
    }

    // Площадь многоугольника - свойство.
    public double Area
    {
        get
        {
            // Аксессор свойства.
            // ToDo 02: реализовать свойство подсчета площади многоугольника
            return 0;
        }
    }

    // Данные о многоугольнике - метод.
    public string PolygonData()
    {
        string res = string.Format("N={0}; R={1}; P={2:F3}; S={3:F3}", numb, radius, Perimeter, Area);
        return res;
    }
}