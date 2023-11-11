/*

Задача.
Описать класс Rectangle, содержащий:
• Два закрытых поля: height и width (типа double), по умолчанию поля имеют единичную длину.
• Свойства (с секциями get и set) для доступа к полям.
• Свойство, возвращающее значение периметра прямоугольника.
• Свойство, возвращающее площадь прямоугольника.
• Переопределённый метод ToString()
• Два конструктора: без параметров и конструктор с двумя параметрами типа double.

В основной программе получить от пользователя значения длин сторон двух
прямоугольников, создать их и вывести на экран значения их площадей и
длин сторон.

*/

using Self01;

Console.Write("Введите ширину прямоугольника1: ");
if (!double.TryParse(Console.ReadLine(), out double width1)) return;

Console.Write("Введите высоту прямоугольника1: ");
if (!double.TryParse(Console.ReadLine(), out double height1)) return;

Console.Write("Введите ширину прямоугольника2: ");
if (!double.TryParse(Console.ReadLine(), out double width2)) return;

Console.Write("Введите высоту прямоугольника2: ");
if (!double.TryParse(Console.ReadLine(), out double height2)) return;


Rectangle rect1 = new(width1, height1);
Rectangle rect2 = new(width2, height2);

Console.WriteLine("\nПрямоугольник 1:");
Console.WriteLine(rect1);
Console.WriteLine(rect1.Square);

Console.WriteLine("\nПрямоугольник 2:");
Console.WriteLine(rect2);
Console.WriteLine(rect2.Square);
