public abstract class Animal{
    public string Name {get; init;}
    protected Animal(string name) {
        Name = name;
    }
    public abstract string Say();
}
public class Cat: Animal {
    public Cat(string name): base(name) { }
    public override string Say() {
        return "Meo-Meo";
    }
}
public class Dog: Animal {
    public Dog(string name): base(name) { }
    public override string Say() {
        return "Gav-Gav";
    }
}

public class Program
{
    public static void Main()
    {
        Animal animal = new Cat("Pushok");
        Console.WriteLine($"{animal.Name} say {animal.Say()}");
        animal = new Dog("Gavrik");
        Console.WriteLine($"{animal.Name} say {animal.Say()}");
    }
}