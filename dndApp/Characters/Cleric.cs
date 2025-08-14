    public class Cleric : BaseCharacter
    {
        public override int initialiseCharacterHealth()
        {
            base.initialiseCharacterHealth();
            //Console.WriteLine($"Cleric's Base Health {DefaultHealth}");
            DefaultHealth += 1; // heal 1 HP
            return DefaultHealth;
        }

        public override int setDefaultAttackValues()
        {
            // can be overriden
            Attack = rand.Next(1, 10);
        //Console.WriteLine($"Cleric's Base Attack {Attack}");
            
            return Attack;

        }
    }
