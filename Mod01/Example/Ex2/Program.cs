// Лазаренко Александр Николаевич, БПИ234, вариант х

using System;

class Programm
{
    static void Main()
    {
        while (true)
        {
            double f, g, e;

            Console.Write("Введите f: ");
            bool flag1 = double.TryParse(Console.ReadLine(), out f);

            Console.Write("Введите g: ");
            bool flag2 = double.TryParse(Console.ReadLine(), out g);

            Console.Write("Введите e: ");
            bool flag3 = double.TryParse(Console.ReadLine(), out e);

            double a = (Math.Pow(f - g, 3) - 7) / (Math.Pow(g + e, 2)) - 7 * ((e * f - f * f * g / 3.0) / (25 - g));
            double x = 43 * 43 * a - 42 * 42 * g / 27.3 + (16 + g) / (g - e);
            double w = x / 100 + 25 * 25 / x + a / (3 * f) - (g + e * e) / (e + g * g);
            double h = g - f * f - 7 * e * e * w / 3.0 - x * x / (4.5 * f * e);

            string res = String.Format("f: {0:f3}\ng: {1:f3}\ne: {2:f3}\na: {3:f3}\nx: {4:f3}\nw: {5:f3}\nh: {6:f3}\n", f, g, e, a, x, w, h);
            bool resolution = flag1 && flag2 && flag3 && !double.IsNaN(a) && !double.IsNaN(x) && !double.IsNaN(w) && !double.IsNaN(h);

            Console.WriteLine(resolution ? res : "Неверные вводные данные");
        }
    }
}