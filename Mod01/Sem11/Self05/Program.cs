/*

Задача. Заполнить квадратную матрицу порядка N случайными
числами в диапазоне [-9.25; 9.33]. Отзеркалить её относительно 
побочной диагонали.

*/

Random rand = new Random();

// Ввод размер матрицы.
Console.Write("Введите размер матрицы: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n <= 0) return;

double[,] matrix = new double[n, n];

// Заполнить матрицу.
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		matrix[i, j] = GetRandom(-9.25, 9.33, 2);
    }
}

Console.WriteLine("\nВаша матрица:");
Print(matrix);

// Отзеркалить матрицу
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		// Если достигнкта побочная диагональ, то перейти к следующей строке.
		if (i == n - j - 1) break;

		// Поменять значения местами.
		Swap(ref matrix[i, j], ref matrix[n - i - 1, n - j - 1]);
	}
}

Console.WriteLine("\nОтзеркаленная матрица:");
Print(matrix);



// Получить случайное число в вещественном диапазоне.
double GetRandom(double min, double max, ushort digits = 2)
{
	// Формула генерации числа в дробном диапазоне.
	double num = rand.NextDouble() * (max - min) + min;

	// Округление до n знаков после запятой (n = digits).
    num = Math.Round(num, digits);

	return num;
}

// Вывести матрицы.
void Print(double[,] arr)
{
	int n = arr.GetLength(0);
	int m = arr.GetLength(1);

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			Console.Write($"{arr[i, j],5}  ");
        }
        Console.WriteLine();
    }
}

// Моменять значения местами.
void Swap(ref double a, ref double b)
{
	double temp = a;
	a = b;
	b = temp;
}

