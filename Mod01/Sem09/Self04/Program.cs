/*

Задача. Ввести размер массива и сгенерировать его элементы в диапозоне [-2; 7]. 
Все чётные элементы поместить в массив arr2, нечётные - в массив arr3.
 
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

int[] arr2 = new int[n], arr3 = new int[n];
int arr2Length = 0, arr3Length = 0;

// Распределение элементов массива.
foreach (int item in arr)
{
    if(item % 2 == 0) arr2[arr2Length++] = item;
    else arr3[arr3Length++] = item;
}

// Подолнать размеры массивов к соответствующим.
Array.Resize(ref arr2, arr2Length);
Array.Resize(ref arr3, arr3Length);

// Вывод массивов.
PrintArr("\nМассив чётных чисел:", arr2);
PrintArr("\nМассив нечётных чисел:", arr3);

