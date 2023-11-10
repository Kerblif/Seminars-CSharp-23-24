/*

Задача.
Пользователь вводит строку. Отсортировать все слова
строки по длине и вывести на экран.

Помимо сортировки по длине, добавлю ещё сортировку 
по алфавиту для слов с одинаковой длиной.

*/

Console.Write("Введите строку: ");
string text = Console.ReadLine();
if (string.IsNullOrEmpty(text)) return;

// Разделить слова по пробелам.
string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
if (words.Length == 0) return;

// Сортровка массива, где ComapareWords - функция, где описаны условия сортировки.
Array.Sort(words, ComapareWords);

foreach (string word in words)
{
    Console.WriteLine(word);
}

// Правила сортировки для строк.
int ComapareWords(string a, string b)
{
    if (a.Length > b.Length) return 1;
    if (a.Length < b.Length) return -1;
    
    // Если длина строк одинакова, то сравнить строки по алфавиту.
    return string.Compare(a, b, true);
}

