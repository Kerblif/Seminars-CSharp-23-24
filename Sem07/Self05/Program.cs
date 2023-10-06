/*
Через НОК, выполнить следующее:

Пример:
Введите числитель: 55
Введите знаменатель: 33
           5    2
Результат: - = 1-
           3    3

*/


// Разложение числа на множители.
Dictionary<int, int> SpreadOut(int num)
{
    num = Math.Abs(num);
    var multipliers = new Dictionary<int, int>();

    while (num > 1)
    {
        for (int i = 2; i <= num; i++)
        {
            if(num % i == 0)
            {
                if(multipliers.ContainsKey(i)) multipliers[i]++;
                else multipliers[i] = 1;
                num /= i;
                break;
            }
        }
    }

    return multipliers;
}

// Вычисление НОКа.
int GetNOC(int a, int b)
{
    // Получить множители чесел A и B.
    var multipliersA = SpreadOut(a);
    var multipliersB = SpreadOut(b);

    int noc = 1;

    foreach (var item in multipliersA)
    {
        // Найти наибольшее количество множителя (у числа A и B).
        int cnt = item.Value;
        if (multipliersB.TryGetValue(item.Key, out int valueB) && valueB > cnt) cnt = valueB;

        noc *= (int)Math.Pow(item.Key, cnt);
    }

    foreach (var item in multipliersB)
    {
        // Применить оставшиеся множители (которых нет в числе A).
        if (multipliersA.ContainsKey(item.Key)) continue;
        noc *= (int)Math.Pow(item.Key, item.Value);
    }

    return noc;
}

// Вывод дроби, где num и den - числитель и знаменатель,
// isWholePart - определяет, надо ли выводить дробную часть.
void PrintFraction(int num, int den, bool isWholePart = false)
{
    // Определение наличия минуса и избавление от него.
    bool isMinus = false;

    if(num < 0)
    {
        isMinus = !isMinus;
        num = -num;
    }
    if(den < 0)
    {
        isMinus = !isMinus;
        den = -den;
    }

    // Знак.
    if (isMinus) Console.Write('-');

    // Целая часть.
    bool hasWholePart = isWholePart && num > den;
    if (hasWholePart)
    {
        Console.Write(num / den);
        num %= den;
    }

    if(isMinus && !hasWholePart) Console.Write(' ');

    // Начальная позиция курсора по оси X.
    int x = Console.CursorLeft;

    int fractionLength = Math.Max(num.ToString().Length, den.ToString().Length);

    // Дробная черта
    Console.Write(new string('─', fractionLength));

    // Перемещение курсора вверх для вывода числителя.
    Console.CursorLeft = x;
    Console.CursorTop--;
    Console.Write(num);

    // Перемещение курсора вниз для вывода знаменателя.
    Console.CursorLeft = x;
    Console.CursorTop += 2;
    Console.Write(den);

    // Перемещение курсора на продолжение.
    Console.CursorLeft = x + fractionLength;
    Console.CursorTop--;
}



// Ввод переменной A.
Console.Write("Введите числитель: ");
bool isA = int.TryParse(Console.ReadLine(), out int a);
if (!isA || a == 0) return;

// Ввод переменной B.
Console.Write("Введите знаменатель: ");
bool isB = int.TryParse(Console.ReadLine(), out int b);
if (!isB || b == 0) return;

// Подсчёт НОКа.
int noc = GetNOC(a, b);

// Вывод результата.
int num = noc / b, den = noc / a;
Console.Write($"\nРезультат: ");
PrintFraction(num, den);

// Если числитель больше знаменателя, то вывести правильную дробь.
if(Math.Abs(num) > Math.Abs(den))
{
    Console.Write(" = ");
    PrintFraction(num, den, true);
}
Console.WriteLine();


