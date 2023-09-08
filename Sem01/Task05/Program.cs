using System;

// Programm class
class Program
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

        while (!double.TryParse(inp, out val))
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
        // Electrical circuit resistance and voltage
        double U = Program.GetDouble("напряжение");
        double R = Program.GetDouble("сопротивление");

        if (R == 0)
        {
            // Zero resistance is unacceptable
            Console.WriteLine("Сопротивление не может быть равно 0!");
        }
        else
        {
            // Result string formatting
            string fstr = String.Format("Сила тока: {0:f2}\nПотребляемая мощность: {1:f2}", U / R, U * U / R);

            // Result printing 
            Console.WriteLine(fstr);
        }
    } // End of 'Main' function.
} // End of 'Program' class
