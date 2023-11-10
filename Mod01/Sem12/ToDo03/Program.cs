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

foreach (var i1 in ch)
    foreach (var i2 in i1)
        foreach (var i3 in i2)
            Console.WriteLine(i3);
