using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            byte n;
            double l;

            do
            {
                Console.Write("Введите n, число углов в правильном многоугольнике: ");
            } while (!byte.TryParse(Console.ReadLine(), out n) || n < 1 || n >= 11);

            do
            {
                Console.Write("Введите l, длину стороны правильного многоугольника: ");
            } while (!double.TryParse(Console.ReadLine(), out l) || l <= 0);

            Console.WriteLine((n * l * l) / (4 * Math.Tan(Math.PI / 4)));
        }
    }
}