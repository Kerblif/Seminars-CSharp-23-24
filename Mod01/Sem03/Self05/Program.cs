using System;

class Program
{
    static double D(double a, double b, double c)
    {
        return b * b - 4 * a * c;
    }

    static void Main()
    {
        while (true)
        {
            double a, b, c;

            do
            {
                Console.Write("Введите a: ");
            } while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("Введите b: ");
            } while (!double.TryParse(Console.ReadLine(), out b));

            do
            {
                Console.Write("Введите c: ");
            } while (!double.TryParse(Console.ReadLine(), out c));

            Console.WriteLine(String.Format("{0}*x^2 + {1}*x + {2} = 0", a, b, c));

            if (a == 0)
            {
                Console.WriteLine("Найдено 1 решение: x = " + (-c / b));
            } else if (b == 0)
            {
                if (c < 0)
                {
                    Console.WriteLine("Найдено 2 решения: x = +/-" + Math.Sqrt(-c / a));
                } else if (c == 0)
                {
                    Console.WriteLine("Найдено 1 решение: x = 0");
                } else
                {
                    Console.WriteLine("Нет действительных корней");
                }
            } else
            {
                double d = D(a, b, c);

                if (d < 0)
                {
                    Console.WriteLine("Нет действительных корней");
                } else if (d == 0)
                {
                    Console.WriteLine("Найдено 1 решение: x = " + (-b / (2 * a)));
                } else
                {
                    Console.WriteLine("Найдено 2 решения: x1 = " + ((-b + Math.Sqrt(d)) / (2 * a)) + ", x2 = " + ((-b - Math.Sqrt(d)) / (2 * a)));
                }
            }
        }
    }
}