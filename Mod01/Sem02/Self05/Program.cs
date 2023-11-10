using System;
using System.Globalization;

internal class Program
{
    // Get double with request string.
    // ARGUMENTS:
    //   - string reqText
    //     Name of value, that requested.
    // RETURNS:
    //   (double) - requested value.
    static double GetDouble(string reqText)
    {
        // The variable to which the result will be written
        double val = 0;

        // User input string
        Console.Write($"Введите {reqText}: ");
        string? inp = Console.ReadLine();

        while (!double.TryParse(inp, NumberStyles.Any, CultureInfo.GetCultureInfoByIetfLanguageTag("RU"), out val))
        {
            // Error in parsing user input and retry
            Console.Write($"Ошибка парсинга!\nВведите {reqText}: ");
            inp = Console.ReadLine();
        }

        return val;
    } // End of 'GetDouble' function.

    // Main function.
    // ARGUMENTS:
    //   - string[] args
    //     Launch arguments.
    // RETURNS: None.
    static void Main(string[] args)
    {
        while (true)
        {
            double xo = GetDouble("абцису центра окружности");
            double yo = GetDouble("ординату центра окружности");
            double R = GetDouble("радиус окружности");
            double x = GetDouble("абцису точки");
            double y = GetDouble("ординату точки");

            double dx = xo - x;
            double dy = yo - y;

            if (dx * dx + dy * dy <= R * R)
            {
                Console.WriteLine("Точка внутри круга!");
            }
            else
            {
                Console.WriteLine("Точка вне круга!");
            }
        }
    } // End of 'Main' function.
}