using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Какой тип массива использовать:\n1) int\n2) double");

            int oper;
            while (!(1 <= (oper = MyUtils.InputIntValue("типа")) && oper <= 2)) {}

            Console.WriteLine("Каким образом его заполнить:\n1) \"руками\"\n2) случайными числами");

            int inp;
            while (!(1 <= (inp = MyUtils.InputIntValue("заполнения")) && inp <= 2)) { }

            if (oper == 1)
            {
                int[] Arr = new int[10];
                MyUtils.Fill_Array(Arr, inp == 1);
                MyUtils.PrintArray(Arr);
            } else
            {
                double[] Arr = new double[10];
                MyUtils.Fill_Array(Arr, inp == 1);
                MyUtils.PrintArray(Arr);
            }
        }
    }
}