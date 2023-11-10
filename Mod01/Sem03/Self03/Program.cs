using System;

class Program
{
    static int DotState(double x, double y)
    {
        double l = x * x + y * y;

        if (y < 0)
        {
            if (l > 1)
            {
                return 0;
            } else if (l == 1)
            {
                return 2;
            } else
            {
                return 1;
            }
        } else if (y == 0)
        {
            if (l < 1)
            {
                return 1;
            } else if (l >= 1 && l <= 4)
            {
                return 2;
            } else
            {
                return 0;
            }
        } else
        {
            if (l > 4)
            {
                return 0;
            }
            else if (l == 4)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }

    static void Main()
    {
        while (true)
        {
            double x, y;

            do
            {
                Console.Write("Введите x: ");
            } while (!double.TryParse(Console.ReadLine(), out x));

            do
            {
                Console.Write("Введите y: ");
            } while (!double.TryParse(Console.ReadLine(), out y));

            int state = DotState(x, y);

            if (state == 0)
            {
                Console.WriteLine("Точка находится все фигуры!");
            }
            else if (state == 1)
            {
                Console.WriteLine("Точка находится внутри фигуры!");
            }
            else
            {
                Console.WriteLine("Точка находится на границе фигуры!");
            }
        }
    }
}