/*

Задача. Квадратная матрица символьного типа размером NxN
заполняется от датчика случайных чисел по правилу: в строки с
четными номерами заносятся прописные латинские буквы, а в строки с
нечетными номерами – цифры. Нумерация строк выполняется с нуля.
Номер 0 – четный. Значение N определяет пользователь. Сформировать
строку символов путем копирования в нее символов на главной
диагонали. Просмотр диагонали выполняется сверху вниз. Для
приведенного примера строка должна иметь вид: A1A9V.

Пример.
A  M  W  Q  E
6  1  7  8  3
Q  Z  A  D  T
4  2  3  9  5
A  X  R  C  V

*/

// Ввод размер матрицы.
Console.Write("Введите размер матрицы: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n <= 0) return;

char[,] matrix = new char[n, n];
Random rand = new Random();

// Заполнить матрицу.
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if(i % 2 == 0)
        {
            matrix[i, j] = (char)(rand.Next('A', 'Z' + 1));
        }
        else
        {
            matrix[i, j] = (char)(rand.Next('0', '9' + 1));
        }
    }
}

Console.WriteLine("\nВаша матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}


Console.Write("\nИтоговая строка: ");
// Вывести главную диагональ.
for (int i = 0; i < n; i++)
{
    Console.Write(matrix[i, i]);
}
Console.WriteLine();

