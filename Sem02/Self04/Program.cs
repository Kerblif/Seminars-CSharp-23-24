using System;
using System.Globalization;

internal class Program
{
    // Main function.
    // ARGUMENTS:
    //   - string[] args
    //     Launch arguments.
    // RETURNS: None.
    static void Main(string[] args)
    {
        while (true)
        {
            int x = Console.Read();
            Console.WriteLine('\n' + (((x >= 'А' && x <= 'Я') || (x >= 'а' && x <= 'я')) ? "Это буква" : ((x >= '0' && x <= '9') ? "Это цифра!" : "Это не цифра и не буква!")));
        }
    } // End of 'Main' function.
}