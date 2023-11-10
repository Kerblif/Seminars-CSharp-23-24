/*

Сформировать для матрицы целых чисел N x M методы:
• заполнения при помощи датчика случайных чисел,
• заполнения при помощи ввода с клавиатуры,
• вывода на экран
• подсчета сумм столбцов с занесением в вектор и его вывода

Организовать выбор способа заполнения матрицы в виде меню.

*/

// Цвета для вывод в консоль.
const ConsoleColor SUCCESS_COLOR = ConsoleColor.DarkGreen;
const ConsoleColor ERROR_COLOR = ConsoleColor.DarkRed;

// Ввод переменной N.
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
if (!isN || n <= 0) return;

// Ввод переменной M.
Console.Write("Введите M: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
if (!isM || m <= 0) return;

int[,] matrix = new int[n, m];
int[] vector = new int[m];
bool isMatrix = false, isVector = false;

Console.CursorVisible = false;
while (true)
{
    Console.Clear();

    // Вывод менюшки.
    Console.WriteLine("[0]: Заполнить случайными числами");
    Console.WriteLine("[1]: Заполнить вводом с клавиатуры");
    Console.WriteLine("[2]: Вывести матрицу");
    Console.WriteLine("[3]: Подсчитать сумму столбцов");
    Console.WriteLine("[4]: Выход");

    Console.Write("\nВыберите действие ");

    // Обработка команд.
    switch (Console.ReadKey(true).KeyChar)
    {
        // Заполнить случайными числами.
        case '0':
            Console.Clear();
            FillMatrixWithRandom(matrix);
            break;

        // Заполнить вводом с клавиатуры.
        case '1':
            Console.Clear();
            FillMatrixWithKeyboard(matrix);
            break;

        // Вывести матрицу.
        case '2':
            Console.Clear();
            Print(matrix);
            break;

        // Подсчитать сумму столбцов и вывести.
        case '3':
            Console.Clear();
            if (CalcSum(matrix, vector))
            {
                PrintVector(matrix, vector);
            }
            break;

        // Выход.
        case '4':
            Console.Write(": ");
            PrintMessage("Выход", SUCCESS_COLOR);
            return;

        default: break;
    }
}


// Заполнить случайными числами.
void FillMatrixWithRandom(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = rand.Next(10);
        }
    }

    // Пометить, что матрица заполнена.
    isMatrix = true;
    // Пометить, что сумма для новой матрицы не подсчитана.
    isVector = false;

    PrintMessage("Таблица заполнена случайными числами.", SUCCESS_COLOR);
    AskForEnter();
}

// Заполнить вводом с клавиатуры.
void FillMatrixWithKeyboard(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    Random rand = new Random();

    Console.CursorVisible = true;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"Введите элемент [{i}; {j}]: ");
            bool isValue = int.TryParse(Console.ReadLine(), out int value);

            // Если было введено не число, то сохранить 0.
            arr[i, j] = isValue ? value : 0;
        }
    }
    Console.CursorVisible = false;

    // Пометить, что матрица заполнена.
    isMatrix = true;

    // Пометить, что сумма для новой матрицы не подсчитана.
    isVector = false;

    Console.Clear();
    PrintMessage("Таблица заполнена.", SUCCESS_COLOR);
    AskForEnter();
}

// Вывести матрицу.
void Print(int[,] arr, bool askForEnter = true)
{
    // Если матрица не заполнена.
    if (!isMatrix)
    {
        PrintMessage("Матрица не заполнена!", ERROR_COLOR);
        AskForEnter();
        return;
    }

    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    Console.WriteLine("Ваша матрица:");

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{arr[i, j], 4} ");
        }
        Console.WriteLine();
    }

    if(askForEnter) AskForEnter();
}

// Вывести массив.
void PrintVector(int[,] matrix, int[] arr)
{
    // Если сумма не подсчитана.
    if(!isVector)
    {
        PrintMessage("Сумма не подсчитана!", ERROR_COLOR);
        AskForEnter();
        return;
    }

    // Вывести матрицу.
    Print(matrix, false);

    // Вывести сумму столбцов.
    Console.WriteLine("\nСумма столбцов:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],4} ");
    }
    Console.WriteLine();

    AskForEnter();
}


// Подсчитать сумму столбцов в vector.
bool CalcSum(int[,] arr, int[] vector)
{
    // Если матрица не заполнена.
    if(!isMatrix)
    {
        PrintMessage("Матрица не заполнена!", ERROR_COLOR);
        AskForEnter();
        return false;
    }

    // Если сумма уже была подсчитана, то не считать ещё раз.
    if (isVector) return true;

    // Занулить сумму.
    Array.Fill(vector, 0);

    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    // Подсчитать сумму.
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            vector[j] += arr[i, j];
        }
    }

    // Пометить, что сумма подсчитана.
    isVector = true;

    return true;
}

// Подождать нажатия Enter.
void AskForEnter()
{
    Console.Write("\nНажмите Enter для продолжения ");
    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
}

// Вывод цветного сообщения в консоль.
void PrintMessage(string msg, ConsoleColor? bgColor = null)
{
    // Если bgColor не null, значит поменять цвет.
    if(bgColor.HasValue)
    {
        Console.ForegroundColor = bgColor.Value;
    }

    Console.WriteLine(msg);

    // Вернуть цвет по умолчанию.
    Console.ResetColor();
}
