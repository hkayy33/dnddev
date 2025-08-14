using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

public class GameFunctionTests
{
    // A list of team players 
    private Program main;

    [SetUp]
    public void setup()
    {
        main = new Program();
    }
    [Test]
    public void Check_If_Three_Characters_Are_Stored_In_A_List()
    {
        Assert.That(Teams.TeamChoice, Is.EqualTo(3));
    }

}