uint school;
string str = Console.ReadLine();
school = uint.Parse(str);

switch (school)
{
    case 1:
    case 2:
    case 3:
    case 4:
        Console.WriteLine("Начальная школа"); break;
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
        Console.WriteLine("Средняя школа"); break;
    case 10:
    case 11:
        Console.WriteLine("Старшая школа"); break;
    default: Console.WriteLine("Такого класса в школе нет!"); break;
}