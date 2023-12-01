using System;
class MyFunction {
    double xmi, xma;
    public MyFunction(double mi, double ma)
    {
        xmi = mi; xma = ma;
    }
    public double this[double x] {
        get {
            return x < xmi | x > xma ? 0 :
                Math.Sin(x);
        }
    }
}
class Program {
    static void Main()
    {
        double rmi = -5, rma = 5;
        MyFunction sin = new MyFunction(0, Math.PI);
        double s = 0, del = 0.001;
        for (double x = rmi; x < rma; x += del)
            s += sin[x];
        s *= del;
        Console.WriteLine(s);
    }
}