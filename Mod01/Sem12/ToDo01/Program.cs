using System;

class Program
{
    public static void Main()
    {
        int n = 4, // Количество строк.
            m = 5; // Количество столбцов.

        double[][] a; // Исходная таблица.

        Utils.FillMass(out a, n, m);

        Console.WriteLine("\nИсходная таблица");
        Utils.PrintMass(a);

        Utils.SwapRows(a);

        Console.WriteLine("\nТаблица после перестановки строк");
        Utils.PrintMass(a);
    }
}