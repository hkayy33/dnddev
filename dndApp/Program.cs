
class Program
{
    static void Main(string[] args)
    {
        //onsole.WriteLine("_______welcome to the Dungeons and Dragons Simulator______");
        int counter = 0;
        Console.Write("Generating Teams");
        while (counter < 15)
        {
            Console.Write(" .");
            counter++;
        }
        return;
        //Print Team A
        var TeamA = new TeamGenerator();
        Console.WriteLine("Team A: ");
        TeamA.TeamChoice();

        var TeamB = new TeamGenerator();
        Console.WriteLine("Team B: ");
        TeamB.TeamChoice();
    }
}


