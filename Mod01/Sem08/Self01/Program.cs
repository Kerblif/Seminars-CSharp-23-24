using System;
using System.Text;

class Program
{
    static double Pi1Summ(double k)
    {
        double res = 0;
        double d = 1000;

        for (double m = 1; m <= k && d > double.Epsilon; m += 1)
        {
            d = 1.0 / (m * Math.Pow(k + 1, 3));
            res += d;
        }

        return res;
    }

    static double Pi1(out int iter)
    {
        double res = 0;
        double d = 1000;

        iter = 0;

        for (double k = 1; d > Math.Pow(10, -10); k += 1, iter++)
        {
            d = 360 * Pi1Summ(k);
            res += d;
        }

        return Math.Pow(res, 1.0/4);
    }

    static double Pi2(out int iter)
    {
        double res = 0;
        double d = 1000;

        iter = 0;

        for (double i = 0; d > double.Epsilon; i += 1, iter++)
        {
            d = Math.Pow(16, -i) * (4.0 / (8 * i + 1) - 2.0 / (8 * i + 4) - 1.0 / (8 * i + 5) - 1.0 / (8 * i + 6));
            res += d;
        }

        return res;
    }

    static void Menu()
    {
        int oper = 0;

        Console.WriteLine("Способы вычисления \u03c0:\n1) Формула приближённого вычисления Бэйли-Боруэйна-Плаффа\n2) Формула приближённого вычисления с использованием кратных рядов");

        do
        {
            Console.Write("Введите номер операции: ");
        } while (!int.TryParse(Console.ReadLine(), out oper) && oper >= 1 && oper <= 2);

        int iter = 0;
        double pi;

        pi = oper switch
        {
            1 => Pi2(out iter),
            2 => Pi1(out iter),
            _ => 0
        };

        Console.WriteLine(String.Format("Погрешность в вычислениях - {0:f10}%", Math.Abs(Math.PI - pi) / Math.PI * 100));
        Console.WriteLine(String.Format("Кол-во итераций для вычисления: {0}", iter));
    }

    static void Main()
    {
        ConsoleKey key = ConsoleKey.M;
        Console.OutputEncoding = Encoding.UTF8;

        while (key != ConsoleKey.Escape)
        {
            Menu();

            Console.WriteLine("Нажмите ESC для выхода...");
            key = Console.ReadKey().Key;
        }
    }
}