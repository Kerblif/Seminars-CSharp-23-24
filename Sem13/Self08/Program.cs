/*

Задача.
Сохранить исходный текст (несколько строк) в файл в
разных кодовых страницах. Потом считать его тоже в разных
кодировках и вывести на экран результат.

*/


using System.Text;

const string fileName = "text.dat";

// Ввод многострочного текста.
Console.WriteLine("Введите многострочный текст:");
string text = ReadMultilineText();

// Запись файла.
if(WriteText(text))
{
    Console.WriteLine("\nТекст записан в один файл в двух кодировках.");
}
else
{
    Console.WriteLine("Неудалось записать файл!");
    return;
}


// Чтение файла.
if(ReadText(out string textFromFile))
{
    Console.WriteLine("\nТекст прочитан из файл в двух кодировках. Текст:");
    Console.WriteLine(textFromFile);
}
else
{
    Console.WriteLine("Неудалось прочитать файл!");
    return;
}



// Функция реализующая ввод многострочного текста.
string ReadMultilineText() {
    StringBuilder sb = new StringBuilder();

    int rowIndex = 0;
    int startRow = Console.CursorTop;
    string infoMessage = "Нажмите Enter, чтобы ввести строку, или ESC, чтобы закончить ввод";

    while (true)
    {
        // Вывод нумерации строк.
        string title = $"{rowIndex + 1}:";
        Console.Write(title);

        // Вывод информационного сообщения о вводе строки либо о прекращении ввода.
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write($"\n\n{infoMessage}");
        Console.ResetColor();

        // Возвращение курсора на место ввода.
        Console.CursorTop = startRow + rowIndex;
        Console.CursorLeft = title.Length;

        // Ожидание команды: продолжить/прекратить ввод.
        ConsoleKey key;
        do
        {
            key = Console.ReadKey(true).Key;
        } while (key != ConsoleKey.Escape && key != ConsoleKey.Enter);

        // Стереть последнюю нумерацию и инфо-сообщение.
        Console.CursorLeft = 0;
        Console.Write($"{new string(' ', title.Length - 1)}\n\n{new string(' ', infoMessage.Length)}");
        Console.CursorTop = startRow + rowIndex;
        Console.CursorLeft = 0;

        // Обработка прекращения ввода.
        if (key == ConsoleKey.Escape) break;

        // Вывод нумерации строки.
        Console.Write(title);

        // Ввод строки и запись её в буфер (StringBuilder).
        string str = Console.ReadLine() ?? "";
        if (rowIndex > 0) sb.AppendLine();
        sb.Append(str);

        // Увеличение строки.
        rowIndex++;
    }

    return sb.ToString();
}

// Запись текста в один файл в двух кодировках.
bool WriteText(string data)
{
    if(data.Length < 2) return false;

    try
    {
        // Разделить текст на две части.
        string textPart1 = data[..(data.Length / 2)];
        string textPart2 = data[(data.Length / 2)..];

        // Получить байты этих частей в разных кодировках.
        byte[] writePart1 = Encoding.UTF32.GetBytes(textPart1);
        byte[] writePart2 = Encoding.UTF7.GetBytes(textPart2);

        // Открыть поток для записи. Записать сначала количество байт, а затем и сами байты.
        using FileStream fs = new FileStream(fileName, FileMode.Create);
        using BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode);

        bw.Write(writePart1.Length);
        bw.Write(writePart1);

        bw.Write(writePart2.Length);
        bw.Write(writePart2);

        return true;
    }
    catch
    {
        return false;
    }
}

// Чтение одного файла в двух кодировках.
bool ReadText(out string data)
{
    data = "";

    try
    {
        // Открыть поток для чтения. Прочитать сначала количество байт, а затем и сами байты.
        using FileStream fs = new FileStream("text.dat", FileMode.Open);
        using BinaryReader br = new BinaryReader(fs, Encoding.Unicode);

        int length = br.ReadInt32();
        byte[] readPart1 = br.ReadBytes(length);

        length = br.ReadInt32();
        byte[] readPart2 = br.ReadBytes(length);

        // Получение строк из разных кодировок.
        string read1 = Encoding.UTF32.GetString(readPart1);
        string read2 = Encoding.UTF7.GetString(readPart2);

        data = read1 + read2;
        return true;
    }
    catch
    {
        return false;
    }
}


