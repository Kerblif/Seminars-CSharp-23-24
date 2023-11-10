double A;
int N;

do
{
    Console.Write("Введите A: ");
} while (!(double.TryParse(Console.ReadLine(), out A) && A > 0));

do
{
    Console.Write("Введите N: ");
} while (!(int.TryParse(Console.ReadLine(), out N) && N > 0));


double step = A / N;
double cur = 0;
double V = 0;

while (cur++ < N)
{
    V += step * Math.Pow(cur * step, 2);
}

Console.WriteLine("Площадь под функцией " + V);
