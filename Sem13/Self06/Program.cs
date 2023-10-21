/*

Задача.
Дан текст с открывающимися и
закрывающимися круглыми скобками. Определить, что все
скобки имеют пару с учетом их вложенности. Если есть
ошибки, то написать о них на экране.

*/


Console.Write("Введите строку: ");
string text = Console.ReadLine();
if (string.IsNullOrEmpty(text)) return;

if(IsWrongBrackets(text))
{
    Console.WriteLine("Все скобки имеют пару с учетом их вложенности.");
}
else
{
    Console.WriteLine("Скобки расставлены неверно!");
}

// Проверяет, что все скобки имеют пару с учетом их вложенности.
bool IsWrongBrackets(string s)
{
    // Счётчик вложенности скобок.
    int nestedBrackets = 0;

    foreach (char ch in s)
    {
        // Если скобка открывающая - увеличить счётчик.
        if (ch == '(') nestedBrackets++;
        // Если скобка закрывающая - уменьшить счётчик.
        // Если счётчик отрицателен, то значит есть ошибка.
        else if (ch == ')' && --nestedBrackets < 0) return true;
    }

    // Если осталось хоть одна открытая скобка, значит есть ошибка.
    return nestedBrackets != 0;
}
