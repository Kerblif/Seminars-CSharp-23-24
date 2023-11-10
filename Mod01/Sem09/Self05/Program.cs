/*

Задача. Ввести размер массива и сгенерировать его элементы в диапозоне [1; 5]. 
Все повторяющиеся элементы заменить на ноль.
 
Пример:
Исходный массив: 2, 5, 2, 3, 4, 5, 2, 4, 1 ,3 ,4 ,5
Модифицированный массив: 2, 5, 0, 3, 4, 0, 0, 0, 1, 0, 0, 0

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
    // Диапозон [1; 5]
    arr[i] = random.Next(1, 6);
}


// Вывод массива.
PrintArr("\nСгенерированный массив:", arr);

// "Волшебная" коллекция для быстрого поиска (не может содержать повторяющиеся элементы).
HashSet<int> set = new HashSet<int>();

// Избавиться от повторяющихся элементов.
for (int i = 0; i < arr.Length; i++)
{
    // Если элемент уже встречался - заменить его на ноль, иначе - добавить в коллекцию.
    if (set.Contains(arr[i])) arr[i] = 0;
    else set.Add(arr[i]);
}


// Вывод массива.
PrintArr("\nОбработанный массив:", arr);
