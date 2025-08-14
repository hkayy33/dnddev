public class Game
{
    private TeamGenerator teamA;
    private TeamGenerator teamB;

    public Game(TeamGenerator a, TeamGenerator b)
    {
        teamA = a;
        teamB = b;
    }

    public void GameRun()
    {
        var arena = CreateArena();
        Fight();
    }

    private List<(BaseCharacter, BaseCharacter)> CreateArena()
    {
        var arena = new List<(BaseCharacter, BaseCharacter)>();
        int count = Math.Min(teamA.team.Count, teamB.team.Count);

        for (int i = 0; i < count; i++)
        {
            arena.Add((teamA.team[i], teamB.team[i]));
        }

        return arena;
    }
    private void Fight()
{
    Console.WriteLine("\n____Battle Start!____");

    int indexA = 0;
    int indexB = 0;

    var fighterA = teamA.team[indexA];
    var fighterB = teamB.team[indexB];

    while (indexA < teamA.team.Count && indexB < teamB.team.Count)
    {
        Console.WriteLine($"\n{fighterA.GetType().Name} (HP: {fighterA.DefaultHealth}) VS {fighterB.GetType().Name} (HP: {fighterB.DefaultHealth})");

        // Fight until one of them dies
        while (fighterA.DefaultHealth > 0 && fighterB.DefaultHealth > 0)
        {
            // A attacks B
            fighterB.DefaultHealth -= fighterA.Attack;
            Console.WriteLine($"{fighterA.GetType().Name} hits {fighterB.GetType().Name} for {fighterA.Attack} damage (HP left: {Math.Max(fighterB.DefaultHealth, 0)})");

            if (fighterB.DefaultHealth <= 0)
            {
                Console.WriteLine($"{fighterB.GetType().Name} is defeated!");
                indexB++;
                if (indexB < teamB.team.Count)
                    fighterB = teamB.team[indexB];
                break;
            }

            // B attacks A
            fighterA.DefaultHealth -= fighterB.Attack;
            Console.WriteLine($"{fighterB.GetType().Name} hits {fighterA.GetType().Name} for {fighterB.Attack} damage (HP left: {Math.Max(fighterA.DefaultHealth, 0)})");

            if (fighterA.DefaultHealth <= 0)
            {
                Console.WriteLine($"{fighterA.GetType().Name} is defeated!");
                indexA++;
                if (indexA < teamA.team.Count)
                    fighterA = teamA.team[indexA];
                break;
            }
        }
    }

    // Announce winner
    if (indexA >= teamA.team.Count)
        Console.WriteLine($"\n{teamB.teamName} Wins!");
    else
        Console.WriteLine($"\n{teamA.teamName} Wins!");
}





}
