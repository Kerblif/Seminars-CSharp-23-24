/*
Задача. 
Получить от пользователя целое число N. Создать
двумерный массив размера в NxN и заполнить его по правилу: 

1    2   …   𝑁−2   𝑁−1   𝑁
2    3   …   𝑁−1   𝑁     1
3    4   …   𝑁     1     2
…    …   …   …     …     …
𝑁−1  𝑁  1    2    …     𝑁−2
𝑁    1  2    …     …    𝑁−1


1  2  3  4  5
2  3  4  5  1
3  4  5  1  2
4  5  1  2  3 
5  1  2  3  4

*/

// Ввод переменной N.
Console.Write("Введите размер матрицы N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n <= 0) return;

int[,] matrix = new int[n, n];

// Заполнение матрицы.
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		// Формулу надо увидеть (догадаться) до неё
		matrix[i, j] = (j + i) % n + 1;
	}
}

// Вывод матрицы.
Console.WriteLine("\nВаша матрица:");
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		Console.Write($"{matrix[i,j],3} ");
    }
    Console.WriteLine();
}


