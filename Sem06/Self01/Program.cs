﻿int p = 0, q = 0;

Console.WriteLine(String.Format("{0,10} | {1,10} | {2,10}", "p", "q", "F"));
do
{
    q = 0;
    do
    {
        Console.WriteLine(String.Format("{0,10} | {1,10} | {2,10}", p == 1, q == 1, !(p == 1 && q == 1) && !(p == 1 || q == 0)));
    } while (++q < 2);
} while (++p < 2);