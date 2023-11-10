/*

Задача.
Преобразовать программу Demo2, итого:
- Ввести резмер матрицы: N и M.
- Заполнить матрицу по правилу a[i, j] = (i+1)*(2*j+1)
- Если матрица квадратная, то занулить все элементы над побочной диагональю.

 */

uint N, M; // Размеры массива.
int[,] ar; // Ссылка на массив.
do
{
    // Ввод переменной N.
    do
    { 
        Console.Write("Введите число строк (N>0): "); 
    }
    while (!uint.TryParse(Console.ReadLine(), out N) || N <= 0);

    // Ввод переменной M.
    do
    { 
        Console.Write("Введите число столбцов (M>0): "); 
    }
    while (!uint.TryParse(Console.ReadLine(), out M) || M <= 0);

    ar = new int[N, M];

    // Заполняем матрицу по правилу.
    FillMatrix(ar);

    Console.WriteLine("\nМатрица до изменения:");
    Print(ar);

    // Если матрица квадратная, то занулить все элементы
    // над побочной диагональю.
    DoOpearation(ar);

    Console.WriteLine("\nМатрица после изменения:");
    Print(ar);

    Console.WriteLine("\nДля выхода нажмите клавишу ESC");
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);



// Заполняем матрицу по правилу.
void FillMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            ar[i, j] = (i + 1) * (2 * j + 1);
        }
    }
}

// Если матрица квадратная, то занулить все элементы
// над побочной диагональю.
void DoOpearation(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    if (n != m) return;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            // Если достигли побочной диагонали, то перейти к новой сктроке.
            if (i == n - j - 1) break;
            matrix[i, j] = 0;
        }
    }
}

// Вывести матрицу.
void Print(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine();
    }
}

