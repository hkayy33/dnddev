class GameLobby
{

    private string? TeamA;
    private string? TeamB;
    private TeamGenerator teamAInstance;
    private TeamGenerator teamBInstance;

    //
    public void Start()
    {
        int counter = 0;
        Console.Write("Generating Teams");
        while (counter < 15)
        {
            Console.Write(" .");
            counter++;
        }
    }

    public void GetTeamNames()
    {
        Console.WriteLine("\nTeam 1 - Enter Team Name: ");
        TeamA = Console.ReadLine();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        if (TeamA.Trim().Equals(""))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Please Enter a Team Name: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            TeamA = Console.ReadLine();

        }
        else if (TeamA != null)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Team 1 READY");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Team 2 - Enter Team Name: ");
            TeamB = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Team 2 READY");
            Console.ForegroundColor = ConsoleColor.Gray;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (TeamB.Trim().Equals(""))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Please Enter a Team Name: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                TeamB = Console.ReadLine();
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        GenerateTeams(TeamA, TeamB);
    }

    public void GenerateTeams(string teamAName, string teamBName)
{
    Console.WriteLine("\n");
    teamAInstance = new TeamGenerator(name: teamAName);
    teamAInstance.TeamChoice();

    teamBInstance = new TeamGenerator(name: teamBName);
    teamBInstance.TeamChoice();
}


    public TeamGenerator GetTeamA() => teamAInstance;
    public TeamGenerator GetTeamB() => teamBInstance;
}