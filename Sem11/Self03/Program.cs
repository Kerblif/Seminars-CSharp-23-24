/*

Cформировать матрицу целых чисел NxM. Задать инициализацию матрицы
при помощи датчика случайных чисел в диапазоне [ -5 ; 5 ]. Отсортировать строки
матрицы без использования методов класса Array. Сортировку массива вынести в
метод. Простейший алгоритм сортировки:
1. Каждый элемент массива сравнивается с последующим и если элемент[i] >
элемент[i+1] происходит замена. Таким образом самые "легкие" элементы
"всплывают" - перемещаются к началу списка, а самые тяжелые "тонут" -
перемещаются к концу.
2. Повторяем шаг 1 n-1 раз, где n – количество элементов в строке матрицы.

*/



// Ввод переменной N.
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n <= 0) return;

// Ввод переменной M.
Console.Write("Введите M: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
if (!isM || m <= 0) return;

int[,] matrix = new int[n, m];
Random rand = new Random();

// Заполнение матрицы. 
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        // Диапазон [-5; 5]
        matrix[i, j] = rand.Next(-5, 6);
    }
}

// Вывод матрицы. 
Console.WriteLine("\nМатрица:");
Print(matrix);

// Сортировка матрицы по правилу.
SortRows(matrix);

// Вывод матрицы. 
Console.WriteLine("\nОтсортированная матрица:");
Print(matrix);


// Вывод матрицы.
void Print(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        Console.Write($"[{i}]:");
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine();
    }
}

// Сортировка матрицы по заданному правилу.
void SortRows(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        // Для каждой строки применить алгоритм.
        for (int j = 0; j < m; j++)
        {
            for (int k = j+1; k < m; k++)
            {
                if (arr[i, j] > arr[i, k])
                {
                    Swap(ref arr[i, j], ref arr[i, k]);
                }
            }
        }
    }
}

// Поменять значения местами.
void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b; 
    b = temp;
}


