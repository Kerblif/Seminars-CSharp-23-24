/*

Задача.
1. Добавьте в класс Birthday конструктор без параметров, 
устанавливающий поля объекта класса в состояние «1 января 1970».
2. Добавьте в класс Birthday методы, позволяющий получить информацию о дне рождения со
следующими форматами представления даты: DD Month YYYY, DD-MM-YY.
3. Решите проблему високосного года (учтите верно количество дней до дня рождения).
4. Добавьте методы для получение текущего значения и изменения значения поля name.

*/


using ToDo03;

Birthday md = new Birthday("Чапаев", 1887, 2, 9);

Console.WriteLine(md.Information);
Console.WriteLine("До следующего дня рождения дней осталось: ");

Console.WriteLine(md.HowManyDays);

Birthday km = new Birthday("Маркс Карл", 1818, 5, 4);

Console.WriteLine(km.Information);
Console.WriteLine("До следующего дня рождения дней осталось: ");

Console.WriteLine(km.HowManyDays);

Console.WriteLine(km.GetDate());
Console.WriteLine(km.GetFullDate());


