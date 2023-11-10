int c = 0;

for (int n = 2000; n <= 3000; n++)
{
    string sn = n.ToString();

    if (!(sn[0] == sn[1] || sn[0] == sn[2] || sn[0] == sn[3] || sn[1] == sn[2] || sn[1] == sn[3] || sn[2] == sn[3]))
    {
        c++;
        Console.WriteLine(n);
    }
}

Console.WriteLine($"Кол-во таких вопросов: {c}");