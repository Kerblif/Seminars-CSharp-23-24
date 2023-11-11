/*

Задача.
Определить класс Circle с полем радиус _r и свойством доступа к
нему, значение радиуса положительное вещественное число. В
классе Circle описать конструктор без параметров и конструктор с
вещественным параметром. Определить свойство S – площадь
круга заданного радиуса. В основной программе получить от
пользователя диапазон изменения значения радиуса: (Rmin,
Rmax), Rmin, Rmax – произвольные вещественные числа и
величину шага delta разбиения данного диапазона. Создать объект
типа Circle, последовательно изменяя значение радиуса на delta
вычислять и выводить на экран значение площади круга,
ограниченного данной окружностью.

*/

using Self02;

Console.Write("Введите начальный радиус (Rmin): ");
if (!double.TryParse(Console.ReadLine(), out double minR) || minR < 0) return;

Console.Write("Введите конечный радиус (Rmax): ");
if (!double.TryParse(Console.ReadLine(), out double maxR) || maxR < 0) return;

Console.Write("Введите шаг для радиуса (delta): ");
if (!double.TryParse(Console.ReadLine(), out double delta) || delta <= 0) return;

Circle circle = new(minR);

while (circle.R <= maxR)
{
    Console.WriteLine($"R = {circle.R:f2}  ->  S = {circle.Square}");
    circle.R += delta;
}
