/*

Задача.
Пользователь вводит строку цифр через пробел:
- Удалить из каждого слова цифру 7
- Добавить в начало каждого слова три цифры 2
- Дописать в конец каждого слова цифру 5
После каждого действия выводить массив слов на экран

Итак, цифра - это число, состоящее из одного символа.

*/

Console.Write("Введите строку цифр через пробелы: ");
string text = Console.ReadLine();
if (string.IsNullOrEmpty(text)) return;

// Разделить слова по пробелам.
string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
if(words.Length == 0 ) return;

// Проверить на корректный ввод.
foreach (string word in words)
{
    if (word.Length == 0 || !int.TryParse(word, out _))
    {
        Console.WriteLine("Неверный формат!");
        return;
    }
}

Console.WriteLine("1) Удалить из каждого слова цифру 7.");
Console.WriteLine("2) Добавить в начало каждого слова три цифры 2.");
Console.WriteLine("3) Дописать в конец каждого слова цифру 5.\n");

Console.Write("0 | ");
Print(words);

// 1) Удалить из каждого слова цифру 7.
for (int i = 0; i < words.Length; i++)
{
    words[i] = words[i].Replace("7", "");
}

Console.Write("1 | ");
Print(words);

// 2) Добавить в начало каждого слова три цифры 2.
for (int i = 0; i < words.Length; i++)
{
    words[i] = "222" + words[i];
}

Console.Write("2 | ");
Print(words);

// 3) Дописать в конец каждого слова цифру 5.
for (int i = 0; i < words.Length; i++)
{
    words[i] += '5';
}

Console.Write("3 | ");
Print(words);


void Print(string[] arr)
{
    foreach (string item in arr)
    {
        Console.Write($"{item, 5} ");
    }
    Console.WriteLine();
}
