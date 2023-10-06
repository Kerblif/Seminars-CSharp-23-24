/*

Задача. Дана строка, содержащая одну отрывающую и закрывающую скобку. 
Вывести строку между этими скобками и длину этой строки.
 
 */

// Ввод строки (если пришёл null, заменить его на пустую строку).
Console.Write("Введите строку: ");
string str = Console.ReadLine() ?? "";

// Найти индексы скобок.
int openI = str.IndexOf('(');
int closeI = str.IndexOf(')');

// Если скобки не были найдены, или открывающая скобка стоит после закрывающей.
if (openI == -1 || closeI == -1 || openI > closeI) return;

// Если строка содержит несколько подобных скобок.
if(str.IndexOf('(', openI+1) != -1 || str.IndexOf(')', closeI+1) != -1) return;

// Получение под строки.
string subStr = str[(openI+1)..closeI];

// Вывод результата.
Console.WriteLine($"Под строка: \"{subStr}\"");
Console.WriteLine($"Длина под строки: {subStr.Length}");
