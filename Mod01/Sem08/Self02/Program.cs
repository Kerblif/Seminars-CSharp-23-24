using System;

class Program
{
    public static bool Triangle(double x, double y, double z, out double p, out double s)
    {
        if ((x > y + z) || (y > x + z) || (z > x + y))
        {
            p = 0;
            s = 0;
            return false;
        }

        p = x + y + z;

        double p2 = p / 2;
        s = Math.Sqrt(p2 * (p2 - x) * (p2 - y) * (p2 - z));

        return true;
    }

    static double InputDouble(string requestString)
    {
        double res = 0;

        do
        {
            Console.Write($"Введите значение {requestString}: ");
        } while (!double.TryParse(Console.ReadLine(), out res));

        return res;
    }

    static void Main()
    {
        ConsoleKey key = ConsoleKey.C;

        while (key != ConsoleKey.Escape)
        {
            double a = InputDouble("первой стороны");
            double b = InputDouble("второй стороны");
            double c = InputDouble("третьей стороны");
            double p, s;

            if (Triangle(a, b, c, out p, out s)) {
                Console.WriteLine($"Периметр: {p}");
                Console.WriteLine($"Площадь: {s}");
            } else
            {
                Console.WriteLine("Такого треугольника не существует");
            }

            Console.WriteLine("Нажмите ESC для выхода...");
            key = Console.ReadKey().Key;
        }
    }
}