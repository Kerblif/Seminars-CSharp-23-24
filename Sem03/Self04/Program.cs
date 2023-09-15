using System;

class Program
{
    static double F(double x, double y)
    {
        if (x < y)
        {
            return Math.Sin(x) + Math.Pow(Math.Cos(y), 2);
        }
        else if (x == y)
        {
            return Math.Log(Math.Abs(x));
        } else
        {
            return Math.Sin(x * x) + Math.Cos(y);
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

            Console.WriteLine($"В точке ({x},{y}) функция F принимает значение {F(x, y)}");
        }
    }
}