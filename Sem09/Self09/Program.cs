/*

Пользователем с клавиатуры вводится целое число N > 0. В программе
сформируйте и выведите целочисленный массив из N элементов, элементами
которого являются нечётные числа от 1
 
*/


// Ввод переменной N и её проверка.
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n < 1) return;

// Получение нечётных значений.
int[] arr = new int[n];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = 2 * i + 1;
}

// Вывод массива.
Console.WriteLine($"\nВаш массив:");
foreach (int item in arr)
{
    Console.Write($"{item}  ");
}


