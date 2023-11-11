/*

Задача.
Определить класс LatinChar с полем _char и свойством
доступа к нему, значение поля – символ латинского
алфавита. Значение поля по умолчанию – ‘a’. Определить
конструкторы класса. В основной программе создать
объект типа LatinChar и, последовательно перебирая все
символы из заданного пользователем диапазона [minChar,
maxChar], выводить значение поля _char объекта.

*/


Console.Write("Введите начальный символ: ");
if (!char.TryParse(Console.ReadLine(), out char min)) return;

Console.Write("Введите конечный символ: ");
if (!char.TryParse(Console.ReadLine(), out char max)) return;

// Если выводить все символы:
//PrintLatinChars();

// Если выводить только латинские буквы:
PrintLatinLetters();



void PrintLatinChars()
{
    for (int i = min; i <= max; i++)
    {
        Console.WriteLine((char)i);
    }
}

void PrintLatinLetters()
{
    int n = Math.Min('Z', max);
    // Сначала выводим заглавные буквы, т.к. их код символа меньше, чем у строчных.
    for (int i = min; i <= n; i++)
    {
        Console.WriteLine((char)i);
    }

    // После вывести строчные буквы.
    n = Math.Min('z', max);
    for (int i = 'a'; i <= n; i++)
    {
        Console.WriteLine((char)i);
    }
}
