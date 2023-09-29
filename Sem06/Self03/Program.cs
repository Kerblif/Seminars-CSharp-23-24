int count = 0;

for (int i = 2000; i <= 3000; i++)
{
    int a, b, c, d;

    a = i / 1000;
    b = i / 100 % 10;
    c = i / 10 % 10;
    d = i % 10;

    if (a == b || a == c || a == d || b == c || b == d || c == d)
    {
        continue;
    } else
    {
        Console.WriteLine(i);
        count++;
    }
}

Console.WriteLine("\nВсего таких чисел: " + count);