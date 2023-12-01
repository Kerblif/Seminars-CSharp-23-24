namespace Program;

public class Mage
{
    protected static Random rnd = new Random();
    
    protected internal int _health;
    protected internal int _damage;
    protected internal int _state;

    public int Health => _health;
    public int Damage => _damage;
    public int State => _state;

    public Mage()
    {
        _health = 0;
        _damage = 0;
        _state = 1;
    }

    public Mage(int health, int damage)
    {
        if (health <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(health));
        }
        
        if (damage <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(damage));
        }
        
        _health = health;
        _damage = damage;
        _state = 1;
    }

    public virtual void Atack(Mage mage)
    {
        if (mage == null || mage._health <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(mage));
        }

        if (_health <= 0)
        {
            throw new Exception("Mage is dead!");
        }
        
        if (_state == 0)
            return;
        
        int dmg = (int)(rnd.NextInt64(Math.Max(0, _damage - 3), _damage + 2) % int.MaxValue) / (_state == 1 ? 1 : 2);

        mage._health -= dmg;
    }

    public override string ToString()
    {
        return $"Health: {_health}; Damage: {_damage}; State: {_state}";
    }
}

public class IceMage : Mage
{
    public override void Atack(Mage mage)
    {
        if (mage == null || mage._health <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(mage));
        }

        if (_health <= 0)
        {
            throw new Exception("Mage is dead!");
        }
        
        if (_state == 2)
            return;
        
        int dmg = (int)(rnd.NextInt64(Math.Max(0, _damage - 3), _damage + 2) % int.MaxValue) / (_state == 1 ? 1 : 2);

        mage._health -= dmg;
        mage._state = Math.Max(0, mage._state - 1);
    }

    public IceMage(int health, int damage) : base(health, damage)
    {
    }
}

public class FireMage : Mage
{
    public override void Atack(Mage mage)
    {
        if (mage == null || mage._health <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(mage));
        }

        if (_health <= 0)
        {
            throw new Exception("Mage is dead!");
        }
        
        if (_state == 2)
            return;
        
        int dmg = (int)(rnd.NextInt64(Math.Max(0, _damage - 3), _damage + 2) % int.MaxValue) / (_state == 1 ? 1 : 2);

        mage._health -= dmg;
        mage._state = Math.Min(2, mage._state + 1);
    }
    
    public FireMage(int health, int damage) : base(health, damage)
    {
    }
}