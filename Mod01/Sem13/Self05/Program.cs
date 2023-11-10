/*

Задача.
Пользователь вводит с клавиатуры строку, в которой
несколько раз идут подряд одинаковые цифры. Найти
наибольшее число, образованное этими цифрами.

Пример:
1111 222в 999 с8795ак 45т6789   ->   8795

*/

Console.Write("Введите строку: ");
string text = Console.ReadLine();
if (string.IsNullOrEmpty(text)) return;

// Сюда будет записано найденное наибольшее число.
ulong? max = null;

// Индекс первой цифры числа.
int index = 0;

for (int i = 0; i < text.Length; i++)
{
    // Если текущий символ - цифра, то перейти к следующиму.
    if (char.IsDigit(text[i])) continue;

    // Если индекс первой цифры числа не равен текущему индексу, то мы нашли число
    // (число закончилось на предыдущем символе).
    if (index != i) ParseNumber(index, i);

    // Текущий символ не цифра, значит предположить,
    // что число начинается со следующего символа.
    index = i + 1;
}
// Если индексы не сходятся, значит строка закончилась числом.
if (index != text.Length) ParseNumber(index, text.Length);

// Вывод результата.
if (max.HasValue) Console.WriteLine($"Наибольшее число: {max}");
else Console.WriteLine("Строка не содержит цифр!");

// Получить подстроку по индексам, и если число больше
// записанного, то перезаписать максимальльное число.
void ParseNumber(int start, int end)
{
    ulong value = ulong.Parse(text[start..end]);
    if(!max.HasValue || value > max) max = value;
}

