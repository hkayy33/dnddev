
class Program
{

    
    static void Main(string[] args)
    {
        //Teams.TeamChoice();
    }
}

public class Teams
{
    private static List<string> Team = new List<string>();
    public static int TeamChoice()
    {
        Team.Add("Fighter");
        Team.Add("Wizard");
        Team.Add("Cleric");

        int number = Team.Count();

        return number;
    }

}