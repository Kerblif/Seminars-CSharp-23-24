/*
Для N >= 1 вывести:

N = 5
*
**
***
****
*****

*/


// Отрисовка треугольника.
void Triangle(int n)
{
    Console.WriteLine($"\nN = {n}");

    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(new string('*', i));
    }
}

// Ввод переменной N.
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n < 1) return;

// Отрисовать треугольник порядка N.
Triangle(n);

