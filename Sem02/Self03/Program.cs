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
        double x = GetDouble("первое число");
        double y = GetDouble("второе число");
        double z = GetDouble("третье число");

        double helper1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
        double helper3 = x > y ? (z > x ? z : x) : (y > z ? y : z);
        double helper2 = ((x >= y && y >= z) || (z >= y && y >= x)) ? y : (((y >= x && x >= z) || (z >= x && x >= y)) ? x : z);

        x = helper1;
        y = helper2;
        z = helper3;

        Console.WriteLine($"{x} {y} {z}");
    } // End of 'Main' function.
}