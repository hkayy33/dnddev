using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;



public class GameFunctionTests
{
    // A list of team players 
    private TeamGenerator teamgenerator;
    private Warrior warrior;


    [SetUp]
    public void setup()
    {
        warrior = new Warrior();
    }
    [Test]
    public void Check_If_Three_Characters_Are_Stored_In_A_List()
    {
        teamgenerator = new TeamGenerator("tester");
        Assert.That(teamgenerator.TeamChoice, Is.EqualTo(3));
    }

    [Test]
    public void Check_that_Random_health_value_is_generated_between_1_and_10_for_Warrior()
    {
        Assert.That(warrior.initialiseCharacterHealth, Is.GreaterThanOrEqualTo(1));
        Assert.That(warrior.initialiseCharacterHealth, Is.LessThanOrEqualTo(10));
    }
    [Test]
    public void Check_that_Random_Attack_value_is_generated_between_1_and_10_for_Warrior()
    {
        Assert.That(warrior.setAttackValues, Is.GreaterThanOrEqualTo(1));
        Assert.That(warrior.setAttackValues, Is.LessThanOrEqualTo(10));
    }

}