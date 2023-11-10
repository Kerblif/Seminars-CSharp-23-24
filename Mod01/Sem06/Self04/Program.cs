// ((((1 ? 2) ? 3) ? 4) ? 5) ? 6

int oper(int a, int b, int op)
{
    return op switch
    {
       0 => a + b,
       1 => a - b,
       2 => a * b,
       3 => a / b,
       _ => 0
    };
}

string operToCh(int op)
{
    return op switch
    {
        0 => "+",
        1 => "-",
        2 => "*",
        3 => "/",
        _ => "?"
    };
}

for (int o1 = 0; o1 < 4; o1++)
{
    for (int o2 = 0; o2 < 4; o2++)
    {
        for (int o3 = 0; o3 < 4; o3++)
        {
            for (int o4 = 0; o4 < 4; o4++)
            {
                for (int o5 = 0; o5 < 4; o5++)
                {
                    if (oper(oper(oper(oper(oper(1, 2, o1), 3, o2), 4, o3), 5, o4), 6, o5) == 35)
                    {
                        Console.WriteLine($"((((1 {operToCh(o1)} 2) {operToCh(o2)} 3) {operToCh(o3)} 4) {operToCh(o4)} 5) {operToCh(o5)} 6");
                    } 
                }
            }
        }
    }
}