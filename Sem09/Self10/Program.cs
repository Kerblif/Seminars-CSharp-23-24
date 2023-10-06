/*

Пользователем с клавиатуры вводятся целые числа N > 1, A и D. В
программе сформируйте и выведите на экран целочисленный массив из N
элементов. Элементы вычисляются:

A[0] = A
A[1] = A + D
A[2] = A + 2 * D

A[N-1] = A + (N-1) * D.

*/

// Ввод переменной N и её проверка.
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n < 1) return;

// Ввод переменной A и её проверка.
Console.Write("Введите A: ");
bool isA = int.TryParse(Console.ReadLine(), out int a);
if (!isA) return;

// Ввод переменной D и её проверка.
Console.Write("Введите D: ");
bool isD = int.TryParse(Console.ReadLine(), out int d);
if (!isD) return;

// Формирование массива.
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = a + i * d;
}

// Вывод массива.
Console.WriteLine($"\nВаш массив:");
foreach (int item in arr)
{
    Console.Write($"{item}  ");
}

