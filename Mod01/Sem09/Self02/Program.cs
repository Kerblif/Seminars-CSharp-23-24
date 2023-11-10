/*

Задача. Ввести размер массива и сгенерировать его элементы в диапозоне [-2; 7]. 
После чего вывести массив.
 
*/

// Ввод размера массива.
Console.Write("Введите размер массива N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n < 1) return;

// Генерация массива.
int[] arr = new int[n];
Random random = new Random();

for (int i = 0; i < n; i++)
{
    // Диапозон [-2; 7]
    arr[i] = random.Next(-2, 8);
}

// Вывод массива.
Console.WriteLine("\nВаш массив:");

for (int i = 0; i < n; i++)
{
    Console.Write($"{arr[i]}  ");
}
Console.WriteLine();



