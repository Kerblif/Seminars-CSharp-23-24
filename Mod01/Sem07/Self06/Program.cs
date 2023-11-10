/*
Вывод чисел стирлинга.
При N = 5, K = 2:

Стирлинг (1) sgn:  -50
Стирлинг (1) usgn: 50
Стирлинг (2):      15
*/

// Ввод переменной N.
using Self06;

Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN) return;

// Ввод переменной K.
Console.Write("Введите K: ");
bool isK = int.TryParse(Console.ReadLine(), out int k);
if (!isK) return;


// Вывод значений Стирлинга N и K.

Console.Write("Стирлинг (1) sgn:  ");
if (Stirling.IsStirling1Sign(n, k, out long value1)) Console.WriteLine(value1);
else Console.WriteLine("Не существует!");

Console.Write("Стирлинг (1) usgn: ");
if (Stirling.IsStirling1USign(n, k, out long value2)) Console.WriteLine(value2);
else Console.WriteLine("Не существует!");

Console.Write("Стирлинг (2):      ");
if (Stirling.IsStirling2(n, k, out long value3)) Console.WriteLine(value3);
else Console.WriteLine("Не существует!");

