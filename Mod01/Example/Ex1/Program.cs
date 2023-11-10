// Лазаренко Александр Николаевич, БПИ234, вариант х

using System;

class Programm
{
    static void Main()
    {
        while (true)
        {
            double x;

            Console.Write("Введите x: ");
            bool flag = double.TryParse(Console.ReadLine(), out x);

            double res = (Math.Abs(Math.Log(x * x)) + 1.0 / 3.0) / (Math.Sqrt(Math.Pow(Math.E, x / Math.PI) + Math.Pow(x, 1.0 / 3.0) + 1.4));
            Console.WriteLine(flag ? String.Format("Результат: {0:f5}\n", res) : "Неверные входные данные");
        }
    }
}