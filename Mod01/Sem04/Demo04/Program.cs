uint school;
string str = Console.ReadLine();
school = uint.Parse(str);

string output = school switch
{

    >= 1 and <= 4 => "Начальная школа",
    >= 5 and <= 9 => "Средняя школа",
    >= 10 and <= 11 => "Старшая школа",
    _ => ("Нет такого класса в школе")
};
Console.WriteLine(output);