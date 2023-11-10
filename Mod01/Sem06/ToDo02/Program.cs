char rep;

do
{
    Console.Clear();

    Console.Write("Для повтора вычислений нажмите клавишу Y: ");
    rep = char.Parse(Console.ReadLine());
} while (rep == 'Y' || rep == 'y');