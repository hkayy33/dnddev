public class TeamGenerator
{
    public List<BaseCharacter> team;
    private string teamName;
    private BaseCharacter[] characterTypes;

    public TeamGenerator(string name)
    {
        teamName = name;
        team = new List<BaseCharacter>();
        characterTypes = [new Warrior(), new Cleric(), new Wizard()];
    }


    public int TeamChoice()
    {
        team.Clear();
        Random rand = new Random();

        // Add 3 random character objects
        for (int i = 0; i < 3; i++)
        {
            int randomIndex = rand.Next(characterTypes.Length);
            team.Add(characterTypes[randomIndex]);
        }

        // Display the team
        Console.WriteLine($"\n{teamName}:");
        for (int i = 0; i < team.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {team[i].GetType().Name}");
        }

        return team.Count;
    }
}