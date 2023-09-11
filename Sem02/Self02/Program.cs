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
        double a = GetDouble("первое число");
        double b = GetDouble("второе число");

        Console.WriteLine($"Сумма целых частей чисел {a} и {b} равна {(int)a + (int)b}");
        Console.WriteLine($"Сумма дробных частей чисел {a} и {b} равна {a % 1 + b % 1}");
    } // End of 'Main' function.
}