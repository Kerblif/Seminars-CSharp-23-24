while (true)
{
    Console.Write("Введите символ: ");
    int ch = Console.Read();

    switch (ch)
    {
        case >= '0' and <= '9':
            Console.WriteLine(String.Format("{0} - это код цифры", ch));
            break;
        case >= 'A' and <= 'Z':
            Console.WriteLine(String.Format("{0} - это код прописной латинской буквы", ch));
            break;
        case >= 'a' and <= 'z':
            Console.WriteLine(String.Format("{0} - это код строчной латинской буквы", ch));
            break;
        default:
            Console.WriteLine(String.Format("{0} - это код неизвестного символа", ch));
            break;
    }
}