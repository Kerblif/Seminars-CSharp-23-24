using System;

class Program
{
    static void Main()
    {
        int[] Arr;
        MyUtils.Fill_Array(out Arr);

        int maxEl;
        if (MyUtils.TryFindMaxElement(Arr, out maxEl))
        {
            Console.WriteLine("Максимальный введенный элемент: " + maxEl);
        } else {
            Console.WriteLine("Не получилось найти максимальный эллемент");
        }
    }
}