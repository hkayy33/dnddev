using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;



public class GameFunctionTests
{
    // A list of team players 
    private TeamGenerator teamgenerator;
    private Warrior warrior;
    private Cleric cleric;
    private Wizard wizard;


    [SetUp]
    public void setup()
    {
        warrior = new Warrior();
        cleric = new Cleric();
        wizard = new Wizard();

    }

    // Team Creation
    [Test]
    public void Check_If_Three_Characters_Are_Stored_In_A_List()
    {
        teamgenerator = new TeamGenerator("tester");
        Assert.That(teamgenerator.TeamChoice, Is.EqualTo(3));
    }


    // Character initialisation

    //warrior
    [Test]
    public void Check_that_Random_health_value_is_generated_between_1_and_15_for_Warrior()
    {
        Assert.That(warrior.initialiseCharacterHealth, Is.GreaterThanOrEqualTo(1));
        Assert.That(warrior.initialiseCharacterHealth, Is.LessThanOrEqualTo(15));
    }
    [Test]
    public void Check_that_Random_Attack_value_is_generated_between_1_and_10_for_Warrior()
    {
        Assert.That(warrior.setDefaultAttackValues, Is.GreaterThanOrEqualTo(1));
        Assert.That(warrior.setDefaultAttackValues, Is.LessThanOrEqualTo(10));
    }

    // Cleric
    [Test]
    public void Check_that_Random_health_value_is_generated_between_1_and_10_for_Cleric()
    {
        Assert.That(cleric.initialiseCharacterHealth, Is.GreaterThanOrEqualTo(1));
        Assert.That(cleric.initialiseCharacterHealth, Is.LessThanOrEqualTo(10));
    }
    [Test]
    public void Check_that_Random_Attack_value_is_generated_between_1_and_10_for_Cleric()
    {
        Assert.That(cleric.setDefaultAttackValues, Is.GreaterThanOrEqualTo(1));
        Assert.That(cleric.setDefaultAttackValues, Is.LessThanOrEqualTo(10));
    }

    // Wizard
    [Test]
    public void Check_that_Random_health_value_is_generated_between_1_and_10_for_Wizard()
    {
        Assert.That(wizard.initialiseCharacterHealth, Is.GreaterThanOrEqualTo(1));
        Assert.That(wizard.initialiseCharacterHealth, Is.LessThanOrEqualTo(10));
    }
    [Test]
    public void Check_that_Random_Attack_value_is_generated_between_1_and_10_for_Wizard()
    {
        Assert.That(wizard.setDefaultAttackValues, Is.GreaterThanOrEqualTo(1));
        Assert.That(wizard.setDefaultAttackValues, Is.LessThanOrEqualTo(20));
    }


    // game funciton
    /*
        We want to alternate between Team A and B
    */

    [Test]
    public void Check_Instance_of_TeamGenerator_is_available()
    {


        Assert.That(Game.Attackers[0], Is.InstanceOf<Warrior>());
    }


}