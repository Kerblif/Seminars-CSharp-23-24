using System;
using System.Globalization;

internal class Program
{
    // Get int 3-digit number with request string.
    // ARGUMENTS:
    //   - string reqText
    //     Name of value, that requested.
    // RETURNS:
    //   (int) - requested value.
    static int GetNumber(string reqText)
    {
        // The variable to which the result will be written
        int val = 0;

        // User input string
        Console.Write($"Введите {reqText}: ");
        string? inp = Console.ReadLine();

        while (!(int.TryParse(inp, NumberStyles.Any, CultureInfo.GetCultureInfoByIetfLanguageTag("RU"), out val) && val / 1000 == 0 && val / 100 != 0))
        {
            // Error in parsing user input and retry
            Console.Write($"Ошибка парсинга!\nВведите {reqText}: ");
            inp = Console.ReadLine();
        }

        return val;
    } // End of 'GetNumber' function.

    // Main function.
    // ARGUMENTS:
    //   - string[] args
    //     Launch arguments.
    // RETURNS: None.
    static void Main(string[] args)
    {
        while (true)
        { 
            int x = GetNumber("трехзначное число");
            x = (x < 0) ? -x : x;

            string strx = x.ToString();
            foreach (var num in strx)
            {
                Console.WriteLine(num);
            }
        }
    } // End of 'Main' function.
}