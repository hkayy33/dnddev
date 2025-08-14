// Each class has a `Health` property, an `Attack` property. When a class is created the health and attack is given a separate random value between 1 and 10. The classes also have the following properties:
// - **Warrior:** The Warrior gets a bonus of 5 to their health regardless of the random value.
// - **Wizard:** The Wizard's attack is doubled regardless of the random value but looses 1 health point when they attack.
// - **Cleric:** The Cleric can heal themselves for 1 health point whenever they attack.

public abstract class BaseCharacter
{
    protected int DefaultHealth;
    protected int Attack;
    protected Random rand = new Random();

    public virtual int initialiseCharacterHealth()
    {
        //can be overriden
        DefaultHealth = rand.Next(1, 10);
        return DefaultHealth;
    }

    public virtual int setAttackValues()
    {
        // can be overriden
        Attack = rand.Next(1, 10);
        return Attack;
        
    }

    
    
}


