double x;

do
{
    Console.Write("Введите X: ");
} while (!double.TryParse(Console.ReadLine(), out x));

double y;

do
{
    Console.Write("Введите Y: ");
} while (!double.TryParse(Console.ReadLine(), out y));

double r = Math.Sqrt(x * x + y * y);

Console.WriteLine((r <= 2 && (x <= 0 || y >= x)) ? "Точка внутри сектора!" : "Точка вне сектора!");
