int K;
double sum = 0;

do
{
    Console.Write("Введите K: ");
} while (!(int.TryParse(Console.ReadLine(), out K) && K > 0));

for (int i = 1; i <= K; i++)
{
    sum += 1d / i; 
}

Console.WriteLine("Результат: " + sum);
