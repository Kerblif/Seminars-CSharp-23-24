using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class MyUtils
{
    static Random rnd = new Random();

    public static double InputDoubleValue(string req)
    {
        double res;

        do
        {
            Console.Write($"Введите значение {req}: ");
        } while (!double.TryParse(Console.ReadLine(), out res));

        return res;
    }

    public static int InputIntValue(string req)
    {
        int res;

        do
        {
            Console.Write($"Введите значение {req}: ");
        } while (!int.TryParse(Console.ReadLine(), out res));

        return res;
    }

    public static void Fill_Array(double[] Arr, bool userInput)
    {
        if (userInput)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = InputDoubleValue($"Введите значение {i}-го элемента:");
            }
        }
        else
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rnd.NextDouble() * 200 - 100;
            }
        }
    }

    public static void Fill_Array(int[] Arr, bool userInput)
    {
        if (userInput)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = InputIntValue($"Введите значение {i}-го элемента:");
            }
        }
        else
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rnd.Next();
            }
        }
    }

    public static void PrintArray<T>(T[] Arr)
    {
        Console.Write("[");

        for (int i = 0; i < Arr.Length; i++)
        {
            Console.Write($"{Arr[i]}{(i != Arr.Length - 1 ? ", " : "")}");
        }

        Console.WriteLine("]");
    }
}
