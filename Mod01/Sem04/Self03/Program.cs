while (true)
{
    int oper = 0;

    do
    {
        Console.Write("Введите код операции: ");
    } while (!(int.TryParse(Console.ReadLine(), out oper) && oper >= 1 && oper <= 4));

    double A = 0;
    do
    {
        Console.Write("Введите A: ");
    } while (!double.TryParse(Console.ReadLine(), out A));

    double B = 0;
    do
    {
        Console.Write("Введите B: ");
    } while (!double.TryParse(Console.ReadLine(), out B));

    string strOper = oper switch
    {
        1 => "+",
        2 => "-",
        3 => "*",
        4 => "/",
        _ => "?"
    };

    double C = oper switch { 
        1 => A + B,
        2 => A - B,
        3 => A * B,
        4 => A / B,
        _ => double.NaN
    };

    Console.WriteLine($"{A} {strOper} {B} = {C}");
}