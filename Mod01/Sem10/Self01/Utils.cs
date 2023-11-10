using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class MyUtils
{
    static Random rnd = new Random();

    public static void FillRandomDouble(double[] Arr, double a, double b)
    {
        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = rnd.NextDouble() * (b - a) + a;
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
