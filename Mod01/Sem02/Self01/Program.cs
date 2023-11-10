using System;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 'a';
        double b = 'a';
        char c = 'a';

        Console.WriteLine(a);
        Console.WriteLine(a.GetType());
        Console.WriteLine(b);
        Console.WriteLine(b.GetType());
        Console.WriteLine(c);
        Console.WriteLine(c.GetType());
    }
}