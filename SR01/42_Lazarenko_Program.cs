// Лазаренко Александр Николаевич, БПИ234, 42 вариант.

using System;

// Programm class.
class Programm
{
    // F method.
    static bool F(int x, int y, int z, int k)
    {
        // Minimum of x, y, z.
        int minValue = Math.Min(x, Math.Min(y, z));

        return (0 < k) && (k == minValue); // Returning result.
    }

    // Main function.
    static void Main()
    {
        int x; // X variable.
        Console.Write("Введите X: ");
        if (!int.TryParse(Console.ReadLine(), out x)) // Try parse X.
        {
            Console.WriteLine("Неверный ввод"); // Wrong input.
            return;
        }

        int y; 
        Console.Write("Введите Y: ");
        if (!int.TryParse(Console.ReadLine(), out y)) // Try parse Y.
        {
            Console.WriteLine("Неверный ввод"); // Wrong input.
            return;
        }

        int z;
        Console.Write("Введите Z: ");
        if (!int.TryParse(Console.ReadLine(), out z)) // Try parse Z.
        {
            Console.WriteLine("Неверный ввод"); // Wrong input.
            return;
        }

        int k;
        Console.Write("Введите K: ");
        if (!int.TryParse(Console.ReadLine(), out k)) // Try parse K.
        {
            Console.WriteLine("Неверный ввод"); // Wrong input.
            return;
        }

        Console.WriteLine($"Значение функции F: {F(x, y, z, k)}"); // Printing result.
    }
}
