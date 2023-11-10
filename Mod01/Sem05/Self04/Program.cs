decimal sum = 0, d = 0;
int step = 1;
decimal Decimal_Epsilon = new decimal(1, 0, 0, false, 28);

do
{
    d = (decimal)1 / (step * (step + 1) * (step + 2));
    sum += d;
    step++;
} while (d > Decimal_Epsilon);

Console.WriteLine(sum);