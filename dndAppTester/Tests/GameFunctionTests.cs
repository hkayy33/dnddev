using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

public class GameFunctionTests
{
    // A list of team players 
    private TeamGenerator teamgenerator;

    [SetUp]
    public void setup()
    {
        
    }
    [Test]
    public void Check_If_Three_Characters_Are_Stored_In_A_List()
    {
        teamgenerator = new TeamGenerator("tester");
        Assert.That(teamgenerator.TeamChoice, Is.EqualTo(3));
    }

}