﻿int a;
int b;
int c;

for (a = 1; a < 3; a++)
{
    for (b = 1; b < 3; b++)
    {
        for (c = 1; c < 3; c++) //Самый быстрый цикл.
        {
            int sum = a + b + c;
            Console.Write($" a = {a} b = {b} c = {c} sum = {sum}\n");
        }
    }
}
Console.ReadLine();