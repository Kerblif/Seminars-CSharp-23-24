class A {
    public void PrintA() {
        Console.Write("A");
    }
}

class B : A {
    public void PrintB() {
        Console.Write("B");
    }
}

class Program
{
    static readonly Random random = new Random();

    public static void Main(string[] args)
    {
        A[] a = new A[10];
        for (int i = 0; i < a.Length; i++)
            a[i] = random.Next(0, 2) < 1
                ? new A()
                : new
                    B();
        Console.WriteLine("Все объекты: ");
        foreach (A element in a)
            element.PrintA();
        Console.WriteLine();
        Console.WriteLine("Объекты класса B: ");
        foreach (A element in a)
            if (element is B)
                element.PrintA();
        Console.WriteLine();
    }
}