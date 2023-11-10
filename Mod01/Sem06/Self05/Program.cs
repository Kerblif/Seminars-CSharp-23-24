int N;

do
{
    Console.Write("Введите N: ");
} while (!int.TryParse(Console.ReadLine(), out N));

double A;

do
{
    Console.Write("Введите A: ");
} while (!double.TryParse(Console.ReadLine(), out A));

double S = 0, P = 1;
double cur = 1;

for (int i = 1; i <= N; i++)
{
    cur /= A;
    S += cur;

    P *= A - i;
}

Console.WriteLine($"S = {S}\nP = {P}");
