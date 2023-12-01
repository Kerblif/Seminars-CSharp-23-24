class Person
{
    private string _name = "";

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public void Print()
    {
        Console.WriteLine($"Этого человека зовут {Name}");
    }
}

class Employee : Person
{
    public void PrintName()
    {
        
    }
}

sealed class Client : Person
{
    
}