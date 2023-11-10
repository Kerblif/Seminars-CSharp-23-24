/*

Задача.
Проверить, как работает конкатенация строк через
объекты String и StringBuilder.

*/

using System.Text;

const string append = "Hello ";
const int count = 100_000;

StringBuilder sb = new StringBuilder();
string str = "";

Console.WriteLine("Подождите, подсчитывается время...");

// Засечь время начала конкатинации.
var SB_start = DateTime.Now;

for (int i = 0; i < count; i++)
{
    sb.Append(append);
}

// Засечь время конца конкатинации.
var SB_finish = DateTime.Now;


// Засечь время начала конкатинации.
var str_start = DateTime.Now;

for (int i = 0; i < count; i++)
{
    str += append;
}

// Засечь время конца конкатинации.
var str_finish = DateTime.Now;


Console.WriteLine($"Время конкатинации строки \"{append}\" {count} раз:");
Console.WriteLine($"Для String: {(str_finish - str_start).TotalSeconds:f2} секунд");
Console.WriteLine($"Для StringBuilder: {(SB_finish - SB_start).TotalMilliseconds:f2} миллисекунд");


