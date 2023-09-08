using System;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string surname = Console.ReadLine();
        string patronymic = Console.ReadLine();

        Console.Write($"Имя: {name}\nФамилия: {surname}\nОтчество: {patronymic}");
    }
}
