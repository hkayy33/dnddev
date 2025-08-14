public class TeamGenerator
{
    // Instance fields (not static anymore)
    public List<string> team;
    private string teamName;
    private List<string> characterTypes;

    // Constructor to initialize the team instance
    public TeamGenerator(string name)
    {
        teamName = name;
        team = new List<string>();
        characterTypes = new List<string> { "Fighter", "Wizard", "Cleric" };
    }
    public int TeamChoice()
    {
        // Available character type
        GenerateRandomTeam(characterTypes);
        Console.WriteLine($"\n{teamName}: ");
        DisplayTeam();
        // Display the team

        int num = team.Count();

        // Return the team as a formatted string
        return num;
    }

    private void DisplayTeam()
    {
        for (int i = 0; i < team.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {team[i]}");
        }
    }

    private void GenerateRandomTeam(List<string> characterTypes)
    {
        Random rand = new Random();
        // Create a team of 3 random characters
        for (int i = 0; i < 3; i++)
        {
            int randomIndex = rand.Next(characterTypes.Count);
            team.Add(characterTypes[randomIndex]);
        }
    }
}