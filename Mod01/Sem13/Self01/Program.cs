/*

Задача.
Пользователь вводит предложение (строку). Напечатать все
его различные слова (уникальные). Слово – последовательность
символов в предложении, не содержащая пробелов.

*/

Console.Write("Введите строку: ");
string text = Console.ReadLine();
if (string.IsNullOrEmpty(text)) return;

// Разделить слова по пробелам.
string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
if (words.Length == 0) return;

// Вывести все слова без повторений (не учитывая регистр).
for (int i = 0; i < words.Length; i++)
{
    bool isUniq = true;

    // Проверить, встречалось ли текущее слово words[i], ранее (до индекса i).
    for (int j = 0; j < i; j++)
    {
        // Если такое же слово (не учитывая регистр) встречалось раньше.
        if (string.Equals(words[i], words[j], StringComparison.CurrentCultureIgnoreCase))
        {
            isUniq = false;
            break;
        }
    }

    // Если слово встретилось впервые - вывести его.
    if (isUniq) Console.WriteLine(words[i]);
}
