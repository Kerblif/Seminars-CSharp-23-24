/*
Для N >= 1 вывести:

N = 5
*** *** *** *** ***
* * * * * * * * * *
* * * * * * * * * *
* * * * * * * * * *
* *** *** *** *** *

*/


// Отрисовка треугольника.
void Snake(int n)
{
    // Отрисовка верхних изгибов змейки.
    for (int i = 0; i < n; i++)
    {
        Console.Write("*** ");
    }
    Console.WriteLine();

    // Отрисовка частей змейки между изгибами.
    for (int i = 2; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("* * ");
        }
        Console.WriteLine();
    }

    // Отрисовка нижних изгибов змейки.
    Console.Write("* ");
    for (int i = 1; i < n; i++)
    {
        Console.Write("*** ");
    }
    Console.WriteLine("*");
}

// Ввод переменной N.
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n < 1) return;

// Отрисовать змейку.
Snake(n);


