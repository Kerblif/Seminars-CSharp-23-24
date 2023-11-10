using System;

class Program
{
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
        int[] Array1 = new int[5] { 1, 2, 3, 24, 5 };
        int[] Array2 = new int[5] { 1, 2, 3, 24, -5 };

        if (MaxArray(Array1) > MaxArray(Array2))
        { Console.WriteLine(" 1 > 2 "); }
        else
        if (MaxArray(Array1) <
        MaxArray(Array2))
        { Console.WriteLine(" 2 > 1 "); }
        else
        { Console.WriteLine(" 1 = 2 "); }
        Console.ReadKey();
    }
}