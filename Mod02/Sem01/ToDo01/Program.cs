/*

Задача.
Убрать public из полей
Создать свойства доступа к полям

*/

class Cat
{
    private string _name;
    private DateTime _birthDay;
    private string _breed;


	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	public DateTime BirthDay
    {
		get { return _birthDay; }
		set 
		{ 
			if(value < DateTime.Now) _birthDay = value; 
		}
	}

	public string Breed
    {
		get { return _breed; }
		set { _breed = value; }
	}

	public Cat() : this("", DateTime.Now, "") { }

    public Cat(string name, DateTime birthDay, string breed)
    {
        _name = name;
        _birthDay = birthDay;
		_breed = breed;
    }

    public string Meow() => "Meow-meow-meow";
}
