using System;

class Program
{
    static void Main()
    {
        double[] Arr = new double[10];

        MyUtils.FillRandomDouble(Arr, -12.25, 12.25);
        MyUtils.PrintArray(Arr);
    }
}