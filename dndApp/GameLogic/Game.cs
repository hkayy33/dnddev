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
        //Fight(arena);
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



}
