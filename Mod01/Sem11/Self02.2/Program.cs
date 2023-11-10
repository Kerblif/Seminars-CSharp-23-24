/*

Задача.
Сформировать и заполнить случайными значениями целочисленную
матрицу размером MxN (M и N задаются с клавиатуры). На экран вывести сумму и
произведение элементов k-ой строки (k – задается с клавиатуры).

*/

// Ввод переменной M.
Console.Write("Введите M: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
if (!isM || m <= 0) return;

// Ввод переменной N.
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n <= 0) return;

int[,] matrix = new int[m, n];
Random rand = new Random();

// Заполнение матрицы. 
for (int i = 0; i < m; i++)
{
	for (int j = 0; j < n; j++)
	{
		matrix[i, j] = rand.Next(1, 10);
	}
}

// Вывод матрицы. 
Console.WriteLine("\nМатрица:");
for (int i = 0; i < m; i++)
{
    Console.Write($"[{i}]:");
    for (int j = 0; j < n; j++)
	{
		Console.Write($"{matrix[i, j],3} ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");

int k;
while (true)
{
    Console.Write("Введите K - индекс строки, для которой надо ");
    Console.Write($"вычислить сумму и произведение [0; {m-1}]: ");
	bool isK = int.TryParse(Console.ReadLine(),out k);

	if(!isK || k < 0 || k >= m)
	{
        Console.WriteLine("Индекс вне матрицы!");
		continue;
    }

	// Значение K корректно.
	break;
}

// Подсчёт суммы и произведения по строке K.
long sum = 0, prod = 1;

for (int i = 0; i < n; i++)
{
    sum += matrix[k, i];
    prod *= matrix[k, i];
}

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Prod: {prod}");

