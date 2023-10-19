using System;

class Utils
{
    public static void FillMass(out double[][] mass, int n, int m)
    {
        mass = new double[n][];
        for (int i = 0; i < n; i++)
        {
            mass[i] = new double[m];
        }

        for (int i = 0; i < mass.Length; i++) //Ввод ступенчатого массива.
            for (int j = 0; j < mass[i].Length; j++)
            {
                Console.Write("Элемент[{0}][{1}]: ", i, j);
                mass[i][j] = double.Parse(Console.ReadLine());
            }
    }

    public static void PrintMass(double[][] mass)
    {
        for (int i = 0; i < mass.Length; Console.WriteLine(), i++) //Ввод ступенчатого массива.
            for (int j = 0; j < mass[i].Length; Console.Write($"{mass[i][j]} "), j++)
                ;
    }

    public static void SwapRows(double[][] a)
    {
        int n = a.Length;
        double[] b;

        for (int n1 = 0, n2 = n - 1; n1 < n / 2; n1++, n2--)
        {
            b = a[n1];
            a[n1] = a[n2];
            a[n2] = b;
        }
    }
}

