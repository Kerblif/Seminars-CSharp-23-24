/*
Для N >= 1 и M => 1 вывести:

N = 4 M = 3
*   *   *
**  **  **
*** *** ***
************


*/


// Отрисовка пилы.
void Saw(int n, int m)
{
    Console.WriteLine($"\nN = {n}  M  = {m}");

    // Формат при n = 4: {0,-4}
    string format = "{0,-" + n + "}";

    for (int i = 1; i <= n; i++)
    {
        string row = new string('*', i);

        for (int j = 0; j < m; j++)
        {
            Console.Write(format, row);
        }
        Console.WriteLine();
    }
}

// Ввод переменной N.
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n < 1) return;

// Ввод переменной M.
Console.Write("Введите M: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
if (!isM || m < 1) return;

// Отрисовать пилу.
Saw(n, m);

