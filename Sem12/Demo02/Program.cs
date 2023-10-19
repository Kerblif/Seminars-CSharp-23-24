char[][][] ch = { // Элементы массива – массивы ссылок на массивы.
    new char [ ][ ]
    {
        new char [ ] {'a', 'b'},
        new char [ ] {'c', 'd', 'e'},
        new char [ ] {'f', 'g', 'h', 'i'}
    },
    new char [ ][ ]
    {
        new char [] {'j', 'k'},
        new char [ ] {'l', 'm', 'n'}
    },
    new char [ ][ ]
    {
        new char [ ] {'o', 'p', 'q', 'r'},
    }
};

Console.WriteLine("ch.Rank = " + ch.Rank);
Console.WriteLine("ch[0].Rank = " + ch[0].Rank);
Console.WriteLine("ch[0][0].Rank = " + ch[0][0].Rank);
Console.WriteLine("ch.GetType() = " + ch.GetType());
Console.WriteLine("ch[1][1][2] = " + ch[1][1][2]);
Console.WriteLine("ch.Length = " + ch.Length);
Console.WriteLine("ch.GetLength(0) = " + ch.GetLength(0));
Console.WriteLine("ch[1].GetLength(0) = " + ch[1].GetLength(0));
