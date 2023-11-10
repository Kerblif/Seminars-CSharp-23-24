/*

Задача. Ввести размер массива и его элементы. После чего вывести массив.
 
*/


// Ввод целого числа.
// title - заголовок перед вводом.
int GetValue(string title)
{
    int value;

    while (true)
    {
        Console.Write(title);
        bool isValue = int.TryParse(Console.ReadLine(), out value);

        // Если не удалось преобразовать введённое значение, то начать сначала.
        if(!isValue)
        {
            Console.WriteLine("Введите число!");
            continue;
        }

        // Значение получено -> выход из цикла.
        break;
    }

    return value;
}

// Ввод размера массива.
int n = GetValue("Введите размер массива N: ");
if (n < 1) return;

// Ввод каждого элемента массива.
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = GetValue($"Введите элемент массива [{i}]: ");
}

// Вывод массива.
Console.WriteLine("\nВаш массив:");

for (int i = 0; i < n; i++)
{
    Console.Write($"{arr[i]}  ");
}
Console.WriteLine();



