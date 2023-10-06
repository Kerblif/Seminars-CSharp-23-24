using System;

class Program
{ 
    static int InputInt(string req)
    {
        int res;

        do
        {
            Console.Write($"Введите значение {req}: ");
        } while (!int.TryParse(Console.ReadLine(), out res));

        return res;
    }

    static void InputArray(int[] Arr)
    {
        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = InputInt($"{i + 1}-е значение массива");
        }
    }

    static void PrintArray(int[] Arr)
    {
        Console.Write("[");

        for (int i = 0; i < Arr.Length; i++)
        {
            Console.Write($"{Arr[i]}{(i != Arr.Length - 1 ? ", " : "")}");
        }

        Console.WriteLine("]");
    }

    static int MaxArray(int[] Arr)
    {
        int maxValue;
        maxValue = Arr[0];
        for (int i = 1; i < Arr.Length; i++)
        {
            if (Arr[i] > maxValue)
            { maxValue = Arr[i]; }
        }
        return maxValue;
    }

    static void Main(string[] args)
    {
        int[] Array1 = new int[5];
        int[] Array2 = new int[5];

        Console.WriteLine("---------Заполните данные по 1-ому массиву---------");
        InputArray(Array1);
        Console.Write("Вы ввели следующий массив: ");
        PrintArray(Array1);

        Console.WriteLine("---------Заполните данные по 2-ому массиву---------");
        InputArray(Array2);
        Console.Write("Вы ввели следующий массив: ");
        PrintArray(Array2);


        Console.WriteLine("---------Результат---------");

        if (MaxArray(Array1) > MaxArray(Array2))
        { Console.WriteLine(" 1 > 2 "); }
        else if (MaxArray(Array1) < MaxArray(Array2))
        {
            Console.WriteLine(" 2 > 1 "); 
        } else 
        {
            Console.WriteLine(" 1 = 2 ");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}