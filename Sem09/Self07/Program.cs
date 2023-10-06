/*

Задача. Создать массив целых чисел A из 20 элементов и инициализировать явно
инициализатором. Массив целых чисел B из 10 элементов заполнить в диапазоне [-12 : 14 ].
Оба массива вывести на экран. В массив С скопировать элементы массива B и дописать в все
четные элементы массива A, вывести на экран. Массив С должен иметь размерность,
соответствующую количеству заносимых в него элементов.
 
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
        if (!isValue)
        {
            Console.WriteLine("Введите число!");
            continue;
        }

        // Значение получено -> выход из цикла.
        break;
    }

    return value;
}


// Ввод каждого элемента массива.
int[] arrA = new int[20];
for (int i = 0; i < arrA.Length; i++)
{
    arrA[i] = GetValue($"Введите элемент массива [{i}]: ");
}

// Генерация массива.
int[] arrB = new int[10];
Random random = new Random();

for (int i = 0; i < arrB.Length; i++)
{
    // Диапозон [-12; 14]
    arrB[i] = random.Next(-12, 15);
}


// Вывод массива.
PrintArr("\nМассив A:", arrA);

// Вывод массива.
PrintArr("\nМассив B:", arrB);

int[] arrC = new int[arrA.Length + arrB.Length];
int arrCLength = arrB.Length;

// Скопировать массив B в массив C.
Array.Copy(arrB, arrC, arrCLength);

// Дописать все чётные элементы из массива A.
foreach (int item in arrA)
{
    if(item % 2 == 0) arrC[arrCLength++] = item;
}

Array.Resize(ref arrC, arrCLength);

// Вывод массива.
PrintArr("\nМассив C:", arrC);
