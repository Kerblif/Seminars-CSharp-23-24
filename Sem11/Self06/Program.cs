/*

Задача. Создать матрицу целых чисел A размером NхM и
заполнить ее случайными числами из диапазона от 10 до 100.
Значения N и M вводятся с клавиатуры. Запомнить в массиве B
минимальный элемент каждой строки матрицы. Вывести:
исходную матрицу A и массив B.

Пример:
Матрица A:  23 10 45
            12 15 9

Массив B:   10 9

*/


// Ввод переменной N.
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n <= 0) return;

// Ввод переменной M.
Console.Write("Введите M: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
if (!isM || m <= 0) return;

int[,] matrix = new int[n, m];
int[] minOfRows = new int[n];

Random rand = new Random();

// Заполнить матрицу.
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		matrix[i, j] = rand.Next(10, 100);
	}
}

// Для поиска минимального элемента, заполним массив максимальными.
Array.Fill(minOfRows, int.MaxValue);

// Поиск минимального елемента.
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		if (minOfRows[i] > matrix[i, j])
		{
			minOfRows[i] = matrix[i, j];
		}
	}
}

// Вывод матрицы.
Console.WriteLine($"\nВаша матрица: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
		Console.Write($"{matrix[i, j], 3}  ");
    }
    Console.WriteLine();
}

// Вывод минимального элемента каждой строки.
Console.WriteLine($"\nМинимальные элементы каждой строки:");
for (int i = 0; i < n; i++)
{
    Console.Write($"{minOfRows[i],3}  ");
}
Console.WriteLine();

