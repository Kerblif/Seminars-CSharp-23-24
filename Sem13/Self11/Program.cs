/*

Задача.
Выявить во введенном с клавиатуры тексте слова (текст
может вводиться как одной, так и несколькими строками),
содержащие гласные латинские буквы, и записать в
результирующую строку. Вывести на экран.

Текст:
AbC dEf GhI 
jKl MnO pQr 
StU vWx YzA

*/


char[] vowels = { 'e', 'u', 'i', 'o', 'a' };

// Инфо-сообщение.
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Чтобы завершить ввод, нажмите Ctrl+Z с новой строки.");
Console.ResetColor();

// Ввод многострочного текста. Обрезка пробельных символов 
// по бокам строки и замена новой строки на пробел.
Console.WriteLine("Введите текст (может состоять из нескольких строк):");
string text = Console.In.ReadToEnd().Trim().Replace(Environment.NewLine, " ");

string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("\nСлова с гласными буквами:");
for (int i = 0; i < words.Length; i++)
{
    // Если в слове нет гласных букв.
    if (words[i].ToLower().IndexOfAny(vowels) == -1) continue;

    // Предположим, что это первое вхождение.
    bool isFirst = true;

    // Докажем, что слово встречалось раньше.
    for (int j = 0; j < i; j++)
    {
        // Если слово встречалось раньше.
        if (words[j] == words[i])
        {
            isFirst = false;
            break;
        }
    }

    // Если же слово стретилось впервые.
    if (isFirst) Console.WriteLine(words[i]);
}


//// пример Linq.
//var wordsWithVowels = words.Select(x => x.ToLower()).Distinct().Where(x => x.IndexOfAny(vowels) != -1);
//Console.WriteLine(string.Join(Environment.NewLine, wordsWithVowels));

