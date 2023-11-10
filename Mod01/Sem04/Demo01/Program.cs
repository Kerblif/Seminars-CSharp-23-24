uint school;
string str = Console.ReadLine();
school = uint.Parse(str);

if (school >= 1 && school <= 4) 
    Console.WriteLine("Начальная школа");
else if (school >= 5 && school <= 9)
    Console.WriteLine("Средняя школа");
else if (school >= 10 && school <= 11) 
    Console.WriteLine("Старшая школа");
