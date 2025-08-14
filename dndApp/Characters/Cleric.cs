    public class Cleric : BaseCharacter
    {
        public override int initialiseCharacterHealth()
        {
            base.initialiseCharacterHealth();
            Console.WriteLine($"Cleric's Base Health {DefaultHealth}");
            return DefaultHealth;
        }

        public override int setDefaultAttackValues()
        {
            // can be overriden
            Attack = rand.Next(1, 10);
            Console.WriteLine($"Cleric's Base Attack {Attack}");
            return Attack;

        }
    }
