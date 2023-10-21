/*

Задача. 
Пользователь вводит строку. Вывеси на экран только те
слова, которые начинаются с латинских букв

*/

Console.Write("Введите строку: ");
string text = Console.ReadLine();
if (string.IsNullOrEmpty(text)) return;

// Разделить слова по пробелам.
string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
if (words.Length == 0) return;

foreach (string word in words)
{
    if (IsLatin(word[0]))
    {
        Console.WriteLine(word);
    }
}

// Проверяет, является ли символ латинской буквой.
bool IsLatin(char ch) => ('a' <= ch && ch <= 'z') || ('A' <= ch && ch <= 'Z');

