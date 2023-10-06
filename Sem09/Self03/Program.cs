/*

Задача. Ввести размер массива и сгенерировать его элементы в диапозоне [-2; 7]. 
Отсортировать в порядке убывания и вывести массив.
 
*/

// Вывод массива.
void PrintArr(string title, int[] arr)
{
    Console.WriteLine(title);

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine();
}

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
PrintArr("\nСгенерированный массив:", arr);

// Сортировка массива.
// Воторой параметр - правила сортировки, где a и b - числа массива.
Array.Sort(arr, (a, b) => a > b ? -1 : a < b ? 1 : 0);

// Вывод массива.
PrintArr("\nОтсортированный массив:", arr);
