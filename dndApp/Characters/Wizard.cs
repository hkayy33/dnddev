public class Wizard : BaseCharacter
{


    public override int initialiseCharacterHealth()
    {
        base.initialiseCharacterHealth();
        Console.WriteLine($"Wizards's Base Health {DefaultHealth}");
        return DefaultHealth;
    }

    public override int setDefaultAttackValues()
    {
        // can be overriden
        Attack = rand.Next(1, 10);
        Attack *= 2;
        Console.WriteLine($"Wizards's Base Attack {Attack}");
        return Attack;

    }
}
