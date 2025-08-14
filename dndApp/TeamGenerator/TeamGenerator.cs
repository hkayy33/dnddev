public class TeamGenerator
{
    public List<BaseCharacter> team;
    private string teamName;
    private Type[] characterTypes;

    public TeamGenerator(string name)
    {
        teamName = name;
        team = new List<BaseCharacter>();
        characterTypes = new Type[] { typeof(Warrior), typeof(Cleric), typeof(Wizard) };
    }

    public int TeamChoice()
    {
        team.Clear();
        Random rand = new Random();

        for (int i = 0; i < 3; i++)
        {
            int randomIndex = rand.Next(characterTypes.Length);
            var fighter = (BaseCharacter)Activator.CreateInstance(characterTypes[randomIndex]);
            fighter.initialiseCharacterHealth();
            fighter.setDefaultAttackValues();
            team.Add(fighter);
        }

        Console.WriteLine($"\n{teamName}:");
        for (int i = 0; i < team.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {team[i].GetType().Name} (HP: {team[i].DefaultHealth}, ATTACK: {team[i].Attack})");
        }

        return team.Count;
    }
}
