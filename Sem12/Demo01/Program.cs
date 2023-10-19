int n = 4, //Количество строк.
m = 5, //Количество столбцов.
mp, //Количество пар строк.
ном1, //Номер первой строки в паре.
ном2, //Номер второй строки в паре.
i, j;
double[][] a; //Исходная таблица.
double[] b; //Буферная ссылка на строку таблицы.
a = new double[n][];
for (i = 0; i < n; i++)
{ a[i] = new double[m]; } //Выделение памяти под строки.

for (i = 0; i < a.Length; i++) //Ввод ступенчатого массива.
    for (j = 0; j < a[i].Length; j++)
    {
        Console.Write("Элемент[{0}][{1}]: ", i, j);
        a[i][j] = double.Parse(Console.ReadLine());
    }
Console.WriteLine("\nИсходная таблица"); //Вывод массива
for (i = 0; i < a.Length; i++, Console.WriteLine())
    for (j = 0; j < a[i].Length; j++)
    { Console.Write("{0,8:f2}", a[i][j]); }
mp = n / 2; //Количество перебрасываемых пар строк.
for (ном1 = 0, ном2 = n - 1; ном1 < mp; ном1++, ном2--)
{
    b = a[ном1];
    a[ном1] = a[ном2];
    a[ном2] = b;
}
Console.WriteLine("\nТаблица после перестановки строк");
for (i = 0; i < a.Length; i++, Console.WriteLine())
    for (j = 0; j < a[i].Length; j++)
        Console.Write("{0,8:f2}", a[i][j]);