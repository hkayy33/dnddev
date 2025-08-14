public class Wizard : BaseCharacter
{


    public override int initialiseCharacterHealth()
    {
        base.initialiseCharacterHealth();
        //Console.WriteLine($"Wizards's Base Health {DefaultHealth}");
        DefaultHealth -= 1; // loses 1 HP each attack
        return DefaultHealth;
    }

    public override int setDefaultAttackValues()
    {
        // can be overriden
        Attack = rand.Next(1, 10);
        Attack *= 2;
        //Console.WriteLine($"Wizards's Base Attack {Attack}");
        return Attack;

    }
}
