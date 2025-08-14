    public class Warrior : BaseCharacter
    {
        public override int initialiseCharacterHealth()
        {
            base.initialiseCharacterHealth();
            DefaultHealth += 5;
            //Console.WriteLine($"Warrior Base Health {DefaultHealth}");
            return DefaultHealth;
        }

        public override int setDefaultAttackValues()
        {
            // can be overriden
            Attack = rand.Next(1, 10);
            //Console.WriteLine($"Warrior Base Attack {Attack}");
            return Attack;

        }
    }
