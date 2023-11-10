int n;

do
{
    Console.Write("Введите число: ");
} while (!int.TryParse(Console.ReadLine(), out n));

int len = Math.Abs(n).ToString().Length;

int k;

do
{
    Console.Write("Введите K: ");
} while (!(int.TryParse(Console.ReadLine(), out k) && k <= len && k >= 0));

for (int i = 0; i < len - k; i++)
{
    n /= 10;
}

Console.WriteLine("Результат: " + n);