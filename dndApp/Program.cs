
class Program
{


    static void Main(string[] args)
    {
        Teams.TeamChoice();
    }
}

public class Teams
{
    private static List<string> team = new List<string>();
 
     private static List<string> characterTypes = new List<string> { "Fighter", "Wizard", "Cleric" };

    public static int TeamChoice()
    {
        // Available character type
        GenerateRandomTeam(characterTypes);
        DisplayTeam();
        // Display the team

        int num = team.Count();

        // Return the team as a formatted string
        return num;
    }

    private static void DisplayTeam()
    {
        Console.WriteLine("Random Team Generated:");
        for (int i = 0; i < team.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {team[i]}");
        }
    }

    private static void GenerateRandomTeam(List<string> characterTypes)
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
