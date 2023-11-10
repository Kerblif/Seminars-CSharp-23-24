/*

Задача*.
Поиск в тексте подстроки «ABCD». Текст получать из
текстового файла input.txt, размещённого в папке с
приложением. Текст может состоять из нескольких строк. При
отсутствии подстрок сообщить об этом.

*/


if(!File.Exists("input.txt"))
{
    Console.WriteLine("Файл input.txt не найден!");
    return;
}

string[] lines = File.ReadAllLines("input.txt");

for (int i = 0; i < lines.Length; i++)
{
    // Индекс, с которого начинается подстрока.
    int start = -1;

    // Пока есть вхождения подстроки.
    while ((start = lines[i].IndexOf("ABCD", start+1)) != -1)
    {
        // Вывод в формате "(<индекс строки>, <индекс символа>)"
        Console.WriteLine($"Значение найдено на позиции ({i}, {start})");
    }
}

