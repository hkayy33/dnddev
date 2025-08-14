
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
        Console.WriteLine("\n");
        //Print Team A
        var TeamA = new TeamGenerator(name: "The Elites");
        TeamA.TeamChoice();
        //Print Team B
        var TeamB = new TeamGenerator(name: "Fantastic 3");
        TeamB.TeamChoice();
    }
}


