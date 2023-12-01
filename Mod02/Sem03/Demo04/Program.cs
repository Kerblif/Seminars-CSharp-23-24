class A
{
    public A(int a)
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public B() : base(0)
    {
        Console.WriteLine("BBB");
    }

    public B(int b) : base(b)
    {
        Console.WriteLine("B");
    }
}

class C : B
{
    public C() : base(0)
    {
        Console.WriteLine("CCC");
    }

    public C(int c) : this()
    {
        Console.WriteLine("C");
    }
}

class Program
{
    static void Main()
    {

        //A aa = new A(0);
        //A ab = new B();
        //A ac = new C(0);
        //B bb = new B();
        //B bc = new C();
        //C cc = new C();
    }
}
