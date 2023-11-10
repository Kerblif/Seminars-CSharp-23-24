int c1 = 0, c2 = 0, c3 = 0;

int t1;
double t2;

while (true)
{
    Console.Write("Введите что-то: ");
    string str = Console.ReadLine();

    bool f1 = int.TryParse(str, out t1);
    bool f2 = double.TryParse(str, out t2);

    if (f1 && (t1 == 0))
    {
        break;
    }

    if (f1) { c1++; }
    if (f2) { c2++; }
    if (!f1 && !f2) { c3++; }
}

Console.WriteLine($"Целые числа: {c1}");
Console.WriteLine($"Дробные числа: {c2}");
Console.WriteLine($"Не числа: {c3}");