/*
Для N >= 1 и M => 1 вывести:

N = 5 M = 3
*
**
***
****
*****
*
**
***
****
*****
*
**
***
****
*****

*/


// Отрисовка ёлочки.
void Ornament(int n, int m)
{
    Console.WriteLine($"\nN = {n}  M  = {m}");

    for (int i = 0; i < m; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            Console.WriteLine(new string('*', j));
        }
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

// Отрисовать ёлочку.
Ornament(n, m);

