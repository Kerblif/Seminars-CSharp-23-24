/*

Задача.
Пользователь вводит строку. Напечатать все различные
слова, встреченные в ней. Слово – последовательность
символов, не содержащая пробелов.

Слова:
Hello World Test Hello Alex world TEST BALL

*/

// Ввод строки.
Console.Write("Введите строку: ");
string text = (Console.ReadLine() ?? "").Trim().ToLower();
if (text.Length == 0) return;

string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


// Решение 1.
// HashSet не может хранить несколько одинаковых значений.
Console.WriteLine("\nРазличные слова (способ 1):");
var nonRepeatingWords1 = new HashSet<string>(words);
foreach (string word in nonRepeatingWords1)
{
	Console.WriteLine(word);
}


// Решение 2.
// Distinct() - метод библиотеки Linq.
Console.WriteLine("\nРазличные слова (способ 2):");
var nonRepeatingWords2 = words.Distinct();
foreach (string word in nonRepeatingWords2)
{
	Console.WriteLine(word);
}


//Решение 3.
// Создать список для поиска индекса значения.
Console.WriteLine("\nРазличные слова (способ 3):");
var list = new List<string>(words);
for (int i = 0; i < words.Length; i++)
{
	// Если индексы совпадают, значит это первое вхождение
	// значения, т.е. раньше это слово не встречалось.
	if (list.IndexOf(words[i]) == i)
	{
		Console.WriteLine(words[i]);
	}
}


// Решение 4 (без доп. структур)
Console.WriteLine("\nРазличные слова (способ 4):");
for (int i = 0; i < words.Length; i++)
{
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
