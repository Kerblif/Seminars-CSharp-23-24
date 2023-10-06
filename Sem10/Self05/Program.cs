using System;

class Program
{
    static void Main()
    {
        int[] Arr1;
        MyUtils.Fill_Array(out Arr1);
        MyUtils.PrintArray(Arr1);
        int[] Arr2;
        MyUtils.Fill_Array(out Arr2);
        MyUtils.PrintArray(Arr2);

        int[] Filter;
        MyUtils.FilterElement(Arr1, out Filter, x => x % 2 == 0);

        Array.Resize(ref Arr2, Arr2.Length + Filter.Length);
        Array.Copy(Filter, 0, Arr2, Arr2.Length - Filter.Length, Filter.Length);

        MyUtils.PrintArray(Arr2);
    }
}