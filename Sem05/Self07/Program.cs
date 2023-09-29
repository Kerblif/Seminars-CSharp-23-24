int num;

do
{
    Console.Write("Введите число: ");
} while (!int.TryParse(Console.ReadLine(), out num));

string snum = num.ToString();
string nnum = "";

for (int i = snum.Length - 1; i >= 0; i--)
{
    nnum += snum[i];
}

Console.WriteLine(int.Parse(nnum));
